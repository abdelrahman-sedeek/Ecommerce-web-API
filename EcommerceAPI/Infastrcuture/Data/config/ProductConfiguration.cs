using EcommerceAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.Infastrcuture.Data.config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.PictureUrl).IsRequired();

            builder.HasOne(b => b.productBrand).WithMany().//WithMany mean that productBrand has many products
                HasForeignKey(b => b.productBrandId);

            builder.HasOne(t => t.ProductType).WithMany().
                HasForeignKey(t => t.ProductTypeId);

        }
    }
}
