using WebSScore_Domain.Entities.Base.Interface;

namespace WebSScore_Domain
{
    public abstract class Entity : IEntity
    {
        public int id { get ; set; }
    }
}