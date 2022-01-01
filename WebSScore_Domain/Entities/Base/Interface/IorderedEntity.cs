namespace WebSScore_Domain.Entities.Base.Interface
{
    public interface IorderedEntity : IEntity
    {
        public int id { get; set; }
        public string name { get; set; }

    }
}
