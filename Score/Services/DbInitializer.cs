using Microsoft.EntityFrameworkCore;

using WebStore.DAL.Context;
using WebStore.Services.Interfaces;

namespace WebStore.Services;

public class DbInitializer : IDbInitializer
{
    private readonly WebStoreDB _db;
    private readonly ILogger<DbInitializer> _Logger;

    public DbInitializer(WebStoreDB db, ILogger<DbInitializer> Logger)
    {
        _db = db;
        _Logger = Logger;
    }

    public async Task<bool> RemoveAsync(CancellationToken Cancel = default)
    {
        _Logger.LogInformation("Удаление БД...");
        var result = await _db.Database.EnsureDeletedAsync(Cancel).ConfigureAwait(false);

        if (result)
            _Logger.LogInformation("Удаление БД выполнено успешно");
        else
            _Logger.LogInformation("Удаление БД не требуется (отсутствует)");

        return result;
    }

    public async Task InitializeAsync(bool RemoveBefore = false, CancellationToken Cancel = default)
    {
        _Logger.LogInformation("Инициализация БД...");

        if (RemoveBefore)
            await RemoveAsync(Cancel).ConfigureAwait(false);

        //await _db.Database.EnsureCreatedAsync();

        var pending_migrations = await _db.Database.GetPendingMigrationsAsync(Cancel);
        if (pending_migrations.Any())
        {
            _Logger.LogInformation("Выполнение миграции БД...");

            await _db.Database.MigrateAsync(Cancel).ConfigureAwait(false);

            _Logger.LogInformation("Выполнение миграции БД выполнено успешно");
        }

        await InitializeProductsAsync(Cancel).ConfigureAwait(false);

        await InitializeEmployeesAsync(Cancel).ConfigureAwait(false);

        _Logger.LogInformation("Инициализация БД выполнена успешно");
    }

    private async Task InitializeProductsAsync(CancellationToken Cancel)
    {
        if (_db.Sections.Any())
        {
            _Logger.LogInformation("Инициализация тестовых данных БД не требуется");
            return;
        }

        _Logger.LogInformation("Инициализация тестовых данных БД ...");

        var sections_pool = MVM.Data.TestData.Employees.Sections.ToDictionary(s => s.id);
        var brands_pool = MVM.Data.TestData.Employees.Brands.ToDictionary(b => b.id);

        foreach (var child_section in MVM.Data.TestData.Employees.Sections.Where(s => s.ParentId is not null))
            child_section.Parent = sections_pool[(int)child_section.ParentId!];

        foreach (var product in MVM.Data.TestData.Employees.Products)
        {
            product.Section = sections_pool[product.SectionId];
            if (product.BrandId is { } brand_id)
                product.Brand = brands_pool[brand_id];

            product.id = 0;
            product.SectionId = 0;
            product.BrandId = null;
        }

        foreach (var section in MVM.Data.TestData.Employees.Sections)
        {
            section.id = 0;
            section.ParentId = null;
        }

        foreach (var brand in MVM.Data.TestData.Employees.Brands)
            brand.id = 0;

        await using (await _db.Database.BeginTransactionAsync(Cancel))
        {
            await _db.Sections.AddRangeAsync(MVM.Data.TestData.Employees.Sections, Cancel);
            await _db.Brands.AddRangeAsync(MVM.Data.TestData.Employees.Brands, Cancel);
            await _db.Products.AddRangeAsync(MVM.Data.TestData.Employees.Products, Cancel);

            await _db.SaveChangesAsync(Cancel);

            await _db.Database.CommitTransactionAsync(Cancel);
        }

        _Logger.LogInformation("Инициализация тестовых данных БД выполнена успешно");
    }

    private async Task InitializeEmployeesAsync(CancellationToken Cancel)
    {
        if (await _db.Employees.AnyAsync(Cancel))
        {
            _Logger.LogInformation("Инициализация сотрудников не требуется");
            return;
        }

        _Logger.LogInformation("Инициализация сотрудников...");
        await using var transaction = await _db.Database.BeginTransactionAsync(Cancel);

        MVM.Data.TestData.Employees.player.ForEach(employee => employee.Id = 0);

        await _db.Employees.AddRangeAsync(MVM.Data.TestData.Employees.player, Cancel);
        await _db.SaveChangesAsync(Cancel);

        await transaction.CommitAsync(Cancel);
        _Logger.LogInformation("Инициализация сотрудников выполнена успешно");
    }
}