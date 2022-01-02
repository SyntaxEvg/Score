using WebSScore_Domain.Entities.Base.Interface;

namespace WebSScore_Domain
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        []
        public string Name { get; set; }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}