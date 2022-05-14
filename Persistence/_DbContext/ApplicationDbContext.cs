using Domain.Layer.EntityMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Layer._DbContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder model)
        {


            model.ApplyConfiguration(new CustomerMapper());
            base.OnModelCreating(model);
           
        }
    }
}
