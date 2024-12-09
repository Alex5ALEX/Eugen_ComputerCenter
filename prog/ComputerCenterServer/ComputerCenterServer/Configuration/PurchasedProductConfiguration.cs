using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ComputerCenterServer.Models;

namespace ComputerCenterServer.Configuration;

public class PurchasedProductConfiguration : IEntityTypeConfiguration<PurchasedProduct>
{
    public void Configure(EntityTypeBuilder<PurchasedProduct> builder)
    {
        builder.HasKey(o => new { o.Id_Order, o.Id_Product });

        builder.HasOne(o => o.Order).WithMany(o => o.PurchasedProduct);

        builder.HasOne(o => o.Product).WithMany(o => o.PurchasedProduct);

    }

}





