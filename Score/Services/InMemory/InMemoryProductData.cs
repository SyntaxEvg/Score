
using Score.Services.Interface;
using WebSScore_Domain;
using WebStore.Components;
using WebStore.Domain.Entities;

namespace WebStore.Services.InMemory;

[Obsolete("Используйте класс WebStore.Services.InSQL.SqlProductData")]
public class InMemoryProductData : IProductData
{
    public IEnumerable<Section> GetSections() => MVM.Data.TestData.Employees.Sections;

    public IEnumerable<Brand> GetBrands() => MVM.Data.TestData.Employees.Brands;

    public IEnumerable<Product> GetProducts(ProductFilter? Filter = null)
    {
        IEnumerable<Product> query = MVM.Data.TestData.Employees.Products;

        //if (Filter?.SectionId != null)
        //    query = query.Where(p => p.SectionId == Filter.SectionId);

        if (Filter?.SectionId is { } section_id)
            query = query.Where(p => p.SectionId == section_id);

        if (Filter?.BrandId is { } brand_id)
            query = query.Where(p => p.BrandId == brand_id);

        return query;
    }

  
}