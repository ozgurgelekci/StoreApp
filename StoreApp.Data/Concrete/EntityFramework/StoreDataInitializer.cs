using System.Collections.Generic;
using System.Data.Entity;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class StoreDataInitializer : DropCreateDatabaseIfModelChanges<StoreAppContext>
    {
        protected override void Seed(StoreAppContext context)
        {
            new List<Category>()
            {
                new Category(){ Name="Telefon"},
                new Category(){ Name="Bilgisayar"},
                new Category(){ Name="Tablet"},
                new Category(){ Name="Kitap"},
                new Category(){ Name="Eğitim"}
            }.ForEach(i => context.Categories.Add(i));
            context.SaveChanges();

            new List<Product>
            {
                new Product() {Name="Samsung S5",Description = "idare eder",Price=800,CategoryId = 1,IsApproved = true},
                new Product() {Name="Samsung S6",Description = "güzel",Price=900,CategoryId = 1,IsApproved = true},
                new Product() {Name="Samsung S5",Description = "idare eder",Price=800,CategoryId = 1},
                new Product() {Name="Ipad",Description = "apple abi yaaa",Price=1000,CategoryId = 3},
                new Product() {Name="Samsung Tablet",Description = "iyi işte",Price=900,CategoryId = 3,IsApproved = true},
                new Product() {Name="Knockout.js eğitimi",Description = "güzel eğitim",Price=200,CategoryId = 5},
                new Product() {Name="Algoritma Kitabı",Description = "başlangıç kitabı",Price=100,CategoryId = 4},
                new Product() {Name="Lenovo Laptop",Description = "Parasına göre sağlam",Price=1200,CategoryId = 2,IsApproved = true},
            }.ForEach(i => context.Products.Add(i));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
