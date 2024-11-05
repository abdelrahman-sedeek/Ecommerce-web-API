namespace EcommerceAPI._ُEntities
{
    public class Product:BaseEntity
    {
        public string? ProductName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand productBrand { get; set; }
        public int productBrandId { get; set; }
    }
}
