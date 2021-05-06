using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Model
{
    public class RequisicaoWidgetContext : DbContext
    {
        public DbSet<RequisicaoWidgetModel> RequisicaoWidgetModel { get; set; }

        public RequisicaoWidgetContext(DbContextOptions<RequisicaoWidgetContext> options) :
            base(options)
        {
        }
    }
}
