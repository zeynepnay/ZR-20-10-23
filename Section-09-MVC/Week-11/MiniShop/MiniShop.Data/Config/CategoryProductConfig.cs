using Microsoft.EntityFrameworkCore;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Config
{
    public class CategoryProductConfig : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(x => new {x.CategoryId, x.ProductId});
            builder.ToTable("CategoryProducts");
        }
    }
}
