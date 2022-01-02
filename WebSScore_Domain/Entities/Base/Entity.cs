using System.ComponentModel.DataAnnotations;
using WebSScore_Domain.Entities.Base.Interface;

namespace WebSScore_Domain
{
    public abstract class Entity : IEntity
    { 
        [Key]
        [DataBaseGenerator]
        public int id { get ; set; }
        
    }
}