using ComputerCenterServer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ComputerCenterServer.Configuration;




public class PurchasedServicesConfiguration : IEntityTypeConfiguration<PurchasedServices>
{
    public void Configure(EntityTypeBuilder<PurchasedServices> builder)
    {
        builder.HasKey(o => new { o.Id_Order, o.Id_Services });

        builder.HasOne(o => o.Order).WithMany(o => o.PurchasedServices);

        builder.HasOne(o => o.Services).WithMany(o => o.PurchasedServices);

    }

}