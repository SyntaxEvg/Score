using WebSScore_Domain;
using WebStore.Components;

namespace Score.Services.Interface
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Product> GetProducts(ProductFilter? Filter = null);
    }
}
  