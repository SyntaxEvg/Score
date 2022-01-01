namespace WebStore.Components
{
    public interface IOrderedEntity : IEntity
    {
        int Order { get; set; }
    }
}