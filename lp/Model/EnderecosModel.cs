using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace CalculadoraDataImob.Models
{
    [Table("view_base_endereco_bairro")]
    public class EnderecosModel
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string uf_nome { get; set; }
        public string labelfind { get; set; }
    }
   
}
