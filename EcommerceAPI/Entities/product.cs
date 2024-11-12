using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI._ُEntities
{
    public class Product:BaseEntity
    {
        public string? ProductName { get; set; }
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int productBrandId { get; set; }
        public ProductBrand productBrand { get; set; }
    }
}
