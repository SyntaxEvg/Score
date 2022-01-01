using WebSScore_Domain.Entities.Base.Interface;
namespace WebSScore_Domain
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

      
    }
}