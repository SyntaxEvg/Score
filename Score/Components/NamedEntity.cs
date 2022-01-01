using System.ComponentModel.DataAnnotations;

public abstract class NamedEntity : Entity, INamedEntity
{
    [Required]
    public string Name { get; set; }
}
