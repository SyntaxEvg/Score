


using Microsoft.EntityFrameworkCore;
using WebSScore_Domain;
using WebSScore_Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities;

[Microsoft.EntityFrameworkCore.Index(nameof(Name))]//Индексация по имени
public class Product : NamedEntity, IOrderedEntity
{
    public int Order { get; set; }

    public int SectionId { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(SectionId))]
    public Section Section { get; set; }

    public int? BrandId { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(BrandId))]
    public Brand Brand { get; set; }

    public string ImageUrl { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public string name { get ; set ; }
}