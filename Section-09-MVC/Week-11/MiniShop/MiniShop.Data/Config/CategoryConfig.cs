using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniShop.Entity;
using System.Reflection.Emit;

namespace MiniShop.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id); //Primary Key
            builder.Property(c => c.Id).ValueGeneratedOnAdd(); //IdentitySpeficitation
            //modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired();
            //modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Name)
            .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Url).IsRequired().HasMaxLength(500);
            builder.ToTable("Categories");
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Televizyon",
                    Description = "Tv Kategorisi",
                    Url = "televizyon"
                },
                new Category
                {
                    Id = 2,
                    Name = "Bilgisayar",
                    Description = "Bilgisayar Kategorisi",
                    Url = "bilgisayar"
                },
                new Category
                {
                    Id = 3,
                    Name = "Elektronik Eşya",
                    Description = "Elektronik Eşya Kategorisi",
                    Url = "elektronik-esya"
                },
                new Category
                {
                    Id = 4,
                    Name = "Beyaz Eşya",
                    Description = "Beyaz Eşya Kategorisi",
                    Url = "beyaz-esya"
                }
                );
        }
    }
}
