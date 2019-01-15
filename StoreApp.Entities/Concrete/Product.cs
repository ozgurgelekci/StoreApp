
using System.ComponentModel.DataAnnotations;
using StoreApp.Entities.Abstract;
using StoreApp.Entities.Concrete;

namespace StoreApp.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Alanı Zorunludur!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Açıklama Alanı Zorunludur!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Fiyat Alanı Zorunludur!")]
        [Range(1, 1500, ErrorMessage = "Fiyat Aralığı 1-500 Arası Olmalıdır!")]
        public decimal Price { get; set; }

        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
