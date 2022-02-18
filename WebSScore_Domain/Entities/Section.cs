using Microsoft.EntityFrameworkCore;
using WebSScore_Domain.Entities.Base.Interface;
using WebStore.Domain.Entities;

namespace WebSScore_Domain
{
    [Index(nameof(Name),IsUnique=true)]
    public class Section: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
   
        public int? ParentId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(ParentId))]
        public Section Parent { get; set; }

        public ICollection<Product> Products { get; set;}
        public string name { get; set; }
    }
}