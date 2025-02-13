using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web_Api_Demo.Domain.Common.Entities;
namespace Web_Api_Demo.Persistence.Configurations
{
    internal class BrandConfiguration:IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);
            Brand bran1 = new Brand() { Id = 1, Name = "Brand1", CreateDate = DateTime.Now,IsDeleted=false };
            Brand bran2 = new Brand() { Id = 2, Name = "Brand2", CreateDate = DateTime.Now, IsDeleted = false };
            Brand bran3 = new Brand() { Id = 3, Name = "Brand3", CreateDate = DateTime.Now, IsDeleted = true };
            builder.HasData(bran1,bran2, bran3);

        }

    }
}
