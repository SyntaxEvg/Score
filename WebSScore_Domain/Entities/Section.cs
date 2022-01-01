using WebSScore_Domain.Entities.Base.Interface;
using WebStore.Components;

namespace WebSScore_Domain
{
    public class Section: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
      
        public int? ParentId { get; set; }
    }
}