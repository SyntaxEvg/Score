using WebSScore_Domain;
using WebStore.Domain;
using WebStore.Domain.Entities;

namespace Score.Services.Interface
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();
        IEnumerable<Brand> GetBrands();
      public  IEnumerable<Product> GetProducts(ProductFilter? Filter = null);
       
    }
}
  