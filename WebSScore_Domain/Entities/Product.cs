using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebSScore_Domain;
using WebSScore_Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities;

[Index(nameof(Name))]//Индексация по имени
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
    public string name { get ; set ; }
}