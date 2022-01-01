using WebSScore_Domain.Entities.Base.Interface;
using WebStore.Components;

namespace WebSScore_Domain
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

      
    }
}