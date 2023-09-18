using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHubBLL.Entities;

namespace TradeHubDAL.Data.Config
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductName)
                .HasMaxLength(100);

            builder.Property(x => x.Brand)
                .HasMaxLength(30);

            builder.HasKey(x => x.SellPrice)
                .HasPrecision(18, 2);
        }
    }
}
