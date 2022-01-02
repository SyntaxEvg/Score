using WebSScore_Domain.Entities.Base.Interface;
using System.ComponentModel.DataAnnotations.Schema;
using WebSScore_Domain.Entities.Base.Interface;
using WebStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebSScore_Domain
{
    [Index(nameof(Name),IsUnique=true)]
    public class Section: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
   
        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Section Parent { get; set; }

        public ICollection<Product> Products { get; set;}
    }
}