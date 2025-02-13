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
    internal class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new Category() { Id = 1, Name = "Elektrik", Priorty = 1, ParentId = 0, IsDeleted = false, CreateDate = DateTime.Now };
            Category category2 = new Category() { Id = 2, Name = "Moda", Priorty = 1, ParentId = 0, IsDeleted = false, CreateDate = DateTime.Now };
            Category category3 = new Category() { Id = 3, Name = "Bilgisayar", Priorty = 1, ParentId = 1, IsDeleted = false, CreateDate = DateTime.Now };
            Category category4 = new Category() { Id = 4, Name = "Kadın", Priorty = 1, ParentId = 2, IsDeleted = false, CreateDate = DateTime.Now };
            builder.HasData(category1, category2, category3, category4);
        }
    }
}
