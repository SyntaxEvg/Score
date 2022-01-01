using WebStore.Components;

namespace WebSScore_Domain
{
    public class Section: NamedEntity, IOrderedEntity
    {
        public int Order
        {
            get
                  => throw new NotImplementedException();
            set
                  => throw new NotImplementedException();
        }
        public int? ParentId { get; set; }
    }
}