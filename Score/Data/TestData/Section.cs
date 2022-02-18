using MVM.Model;
using WebSScore_Domain;
using WebStore.Domain.Entities;

namespace MVM.Data.TestData
{
    public static partial  class Employees
    {
        public static IEnumerable<Section> Sections { get; } = new[]
              {
             new Section { id = 1, Name = "Спорт", Order = 0 },
              new Section { id = 2, Name = "Nike", Order = 0, ParentId = 1 },
              new Section { id = 3, Name = "Under Armour", Order = 1, ParentId = 1 },
              new Section { id = 4, Name = "Adidas", Order = 2, ParentId = 1 },
              new Section { id = 5, Name = "Puma", Order = 3, ParentId = 1 },
              new Section { id = 6, Name = "ASICS", Order = 4, ParentId = 1 },
              new Section { id = 7, Name = "Для мужчин", Order = 1 },
              new Section { id = 8, Name = "Section0", Order = 0, ParentId = 7 },
              new Section { id = 9, Name = "Section1", Order = 1, ParentId = 7 },
              new Section { id = 10, Name = "Valentino", Order = 2, ParentId = 7 },
              new Section { id = 11, Name = "Диор", Order = 3, ParentId = 7 },
              new Section { id = 12, Name = "Версачи", Order = 4, ParentId = 7 },
              new Section { id = 13, Name = "Армани", Order = 5, ParentId = 7 },
              new Section { id = 14, Name = "Prada", Order = 6, ParentId = 7 },
              new Section { id = 15, Name = "Дольче и Габбана", Order = 7, ParentId = 7 },
              new Section { id = 16, Name = "Шанель", Order = 8, ParentId = 7 },
              new Section { id = 17, Name = "Гуччи", Order = 9, ParentId = 7 },
              new Section { id = 18, Name = "Для женщин", Order = 2 },
              new Section { id = 19, Name = "Section2", Order = 0, ParentId = 18 },
              new Section { id = 20, Name = "Guess", Order = 1, ParentId = 18 },
              new Section { id = 21, Name = "Section3", Order = 2, ParentId = 18 },
              new Section { id = 22, Name = "Dior", Order = 3, ParentId = 18 },
              new Section { id = 23, Name = "Versace", Order = 4, ParentId = 18 },
              new Section { id = 24, Name = "Для детей", Order = 3 },
              new Section { id = 25, Name = "Мода", Order = 4 },
              new Section { id = 26, Name = "Для дома", Order = 5 },
              new Section { id = 27, Name = "Интерьер", Order = 6 },
              new Section { id = 28, Name = "Одежда", Order = 7 },
              new Section { id = 29, Name = "Сумки", Order = 8 },
              new Section { id = 30, Name = "Обувь", Order = 9 },
        };

        public static IEnumerable<Brand> Brands { get; } = new[]
        {
            new Brand { id = 1, Name = "Acne", Order = 0 },
            new Brand { id = 2, Name = "Grune Erde", Order = 1 },
            new Brand { id = 3, Name = "Albiro", Order = 2 },
            new Brand { id = 4, Name = "Ronhill", Order = 3 },
            new Brand { id = 5, Name = "Oddmolly", Order = 4 },
            new Brand { id = 6, Name = "Boudestijn", Order = 5 },
            new Brand { id = 7, Name = "Rosch creative culture", Order = 6 },
        };

        public static IEnumerable<Product> Products { get; } = new[]
        {
            new Product { id = 1, Name = "Белое платье", Price = 1025, ImageUrl = "product1.jpg", Order = 0, SectionId = 2, BrandId = 1 },
            new Product { id = 2, Name = "Розовое платье", Price = 1025, ImageUrl = "product2.jpg", Order = 1, SectionId = 2, BrandId = 1 },
            new Product { id = 3, Name = "Красное платье", Price = 1025, ImageUrl = "product3.jpg", Order = 2, SectionId = 2, BrandId = 1 },
            new Product { id = 4, Name = "Джинсы", Price = 1025, ImageUrl = "product4.jpg", Order = 3, SectionId = 2, BrandId = 1 },
            new Product { id = 5, Name = "Лёгкая майка", Price = 1025, ImageUrl = "product5.jpg", Order = 4, SectionId = 2, BrandId = 2 },
            new Product { id = 6, Name = "Лёгкое голубое поло", Price = 1025, ImageUrl = "product6.jpg", Order = 5, SectionId = 2, BrandId = 1 },
            new Product { id = 7, Name = "Платье белое", Price = 1025, ImageUrl = "product7.jpg", Order = 6, SectionId = 2, BrandId = 1 },
            new Product { id = 8, Name = "Костюм кролика", Price = 1025, ImageUrl = "product8.jpg", Order = 7, SectionId = 25, BrandId = 1 },
            new Product { id = 9, Name = "Красное китайское платье", Price = 1025, ImageUrl = "product9.jpg", Order = 8, SectionId = 25, BrandId = 1 },
            new Product { id = 10, Name = "Женские джинсы", Price = 1025, ImageUrl = "product10.jpg", Order = 9, SectionId = 25, BrandId = 3 },
            new Product { id = 11, Name = "Джинсы женские", Price = 1025, ImageUrl = "product11.jpg", Order = 10, SectionId = 25, BrandId = 3 },
            new Product { id = 12, Name = "Летний костюм", Price = 1025, ImageUrl = "product12.jpg", Order = 11, SectionId = 25, BrandId = 3 },
        };
    }
}
