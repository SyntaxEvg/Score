namespace WebSScore_Domain.Entities.Base.Interface
{
    public interface INamedEntity: IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
       
    }
}
