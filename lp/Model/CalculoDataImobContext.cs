using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Model
{
    public class CalculoDataImobContext: DbContext
    {
 
        public DbSet<CalculoDataImobModel> CalculoDataImobModel { get; set; }

        public CalculoDataImobContext(DbContextOptions<CalculoDataImobContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CalculoDataImobModel>(eb =>
                {
                    eb.HasNoKey();
                });

        }


    }
   
}
