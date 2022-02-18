namespace WebSScore_Domain.Entities.Base.Interface
{
    public interface INamedEntity: IEntity
    {
         int id { get; set; }
         string Name { get; set; }
       
    }
}
