﻿using DevFramework.Northwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryID);

            Property(x => x.CategoryID).HasColumnName("CategoryID");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
            Property(x => x.Description).HasColumnName("Description");
        }
    }
}
