using WebStore.Components;

namespace WebSScore_Domain
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order 
        { get 
                => throw new NotImplementedException(); 
          set 
                => throw new NotImplementedException(); 
        }

    }
}