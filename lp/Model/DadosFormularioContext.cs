using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Model
{
    public class DadosFormularioContext : DbContext
    {

        public DbSet<DadosFormularioModel> DadosFormularioModel { get; set; }

        public DadosFormularioContext(DbContextOptions<DadosFormularioContext> options) :
            base(options)
        {
        }

    }
}
