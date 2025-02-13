using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Demo.Domain.Common;
using Web_Api_Demo.Domain.Common.Entities;

namespace Web_Api_Demo.Persistence.Configurations
{
    internal class DetailConfiguration:IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new Detail() {Id=1,Title="Elektrik Ozellikleri",Description="Açıklama",CategoryId=1,CreateDate=DateTime.Now,IsDeleted=false };
            Detail detail2 = new Detail() { Id =2, Title = "Bilgisayar Özellikleri", Description = "Açıklama", CategoryId = 3, CreateDate = DateTime.Now, IsDeleted = true };
            Detail detail3 = new Detail() { Id = 3, Title = "Kadın Moda Ozellikleri", Description = "Açıklama", CategoryId = 4, CreateDate = DateTime.Now, IsDeleted = false };
            builder.HasData(detail1,detail2,detail3);
        }
    }
}
