using WebSScore_Domain.Entities.Base.Interface;

namespace WebSScore_Domain
{
    public class NamedEntity : Entity, INamedEntity
    {
        public string name { get; set; }
    }
}