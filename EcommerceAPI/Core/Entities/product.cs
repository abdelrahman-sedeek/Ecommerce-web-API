using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        public int productBrandId { get; set; }
        public ProductBrand productBrand { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

    }
}
