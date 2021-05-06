using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Model
{

    [Table("empresa_parceira")]
    public class RequisicaoWidgetModel
    {
        [Key]
        public int id_empresa { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string nome_empresa { get; set; }
        public string site_empresa { get; set; }
        public int? leads_max { get; set; }
        public bool? envio_email { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }


    }
}
