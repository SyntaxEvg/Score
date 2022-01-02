namespace WebStore.Services.Interfaces;

public interface IDbInitializer
{
    Task<bool> RemoveAsync(CancellationToken Cancel = default);//мет удален. бд 

    Task InitializeAsync(bool RemoveBefore = false, CancellationToken Cancel = default);
}