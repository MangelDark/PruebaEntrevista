using Domain.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Layer.EntityMapper
{
    public class CustomerMapper : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasKey(x => x.Id).HasName("pk_customerid");
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("Id").HasColumnType("int");

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(x => x.LastName).HasColumnName("LastName").HasColumnType("nvarchar(250)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar(200)").IsRequired();


            builder.Property(x => x.Created).HasColumnName("Created_date").HasColumnType("datetime");
            builder.Property(x => x.Modified).HasColumnName("Modified_date").HasColumnType("datetime");
            builder.Property(x => x.IsActive).HasColumnName("IsActive").HasColumnType("bit");


        }



    }
}
