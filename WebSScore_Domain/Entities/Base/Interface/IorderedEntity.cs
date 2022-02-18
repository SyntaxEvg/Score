namespace WebSScore_Domain.Entities.Base.Interface
{
    public interface IOrderedEntity : IEntity
    {
         int id { get; set; }
         string name { get; set; }

    }
}
