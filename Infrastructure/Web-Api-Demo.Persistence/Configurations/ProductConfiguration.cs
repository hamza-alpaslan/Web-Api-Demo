using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Demo.Domain.Common.Entities;

namespace Web_Api_Demo.Persistence.Configurations
{
    internal class ProductConfiguration:IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new Product() { Id = 1, Title = "Laptop", Description = "Acıklama", BrandId = 1, Discount = 10, Price = 56,IsDeleted=false,CreateDate=DateTime.Now };
            Product product2 = new Product() { Id = 2, Title = "Laptop", Description = "Acıklama", BrandId = 2, Discount = 0, Price = 77, IsDeleted = false, CreateDate = DateTime.Now };
            Product product3 = new Product() { Id = 3, Title = "Laptop", Description = "Acıklama", BrandId = 3, Discount = 30, Price = 100, IsDeleted = false, CreateDate = DateTime.Now };

        }
    }
}
