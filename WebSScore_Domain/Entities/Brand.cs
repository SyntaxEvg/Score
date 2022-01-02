using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebSScore_Domain.Entities.Base.Interface;
using WebStore.Domain.Entities;

namespace WebSScore_Domain
{
    //[Table("Brand")]
    [Index(nameof(Name), IsUnique = true)]
    public class Brand : NamedEntity, IOrderedEntity
    {
       // [Column("")]
        public int Order { get; set; }

       

        public ICollection<Product> Products { get; set; }

    }
}