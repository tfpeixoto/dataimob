using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CalculadoraDataImob.Models
{
    public class EnderecosContext : DbContext
    {
        public DbSet<EnderecosModel> EnderecosModels { get; set; }

        public EnderecosContext(DbContextOptions<EnderecosContext> options) : base(options) {}

        


    }
}
