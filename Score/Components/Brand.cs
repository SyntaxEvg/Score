using Microsoft.EntityFrameworkCore;

namespace WebStore.Components
{
    [Index(nameof(Name), IsUnique = true)]
    public class Brand : NamedEntity, IOrderedEntity
    {
        //[Column("BrandOrder")]
        public int Order { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}