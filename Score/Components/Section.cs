using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebStore.Components;

[Index(nameof(Name), IsUnique = true)]
public class Section : NamedEntity, IOrderedEntity
{
    public int Order { get; set; }

    public int? ParentId { get; set; }

    [ForeignKey(nameof(ParentId))]
    public Section Parent { get; set; }

    public ICollection<Product> Products { get; set; }
}
[Index(nameof(Name))]
public class Product : NamedEntity, IOrderedEntity
{
    public int Order { get; set; }

    public int SectionId { get; set; }

    [ForeignKey(nameof(SectionId))]
    public Section Section { get; set; }

    public int? BrandId { get; set; }

    [ForeignKey(nameof(BrandId))]
    public Brand Brand { get; set; }

    public string ImageUrl { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}
