using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Model
{
   
    [Table("widget_valor_imovel")]
    public class DadosFormularioModel
    {
        
        [ForeignKey("id_empresa")]
        public int? id_empresa { get; set; }
        [Key]
        public int? id_questionario { get; set; }
        public DateTime? data_hora { get; set; }
        public string? deseja_saber { get; set; }
        public string? tipo_imovel { get; set; }
        public string? bairro { get; set; }
        public string? area { get; set; }
        public string? n_quartos { get; set; }
        public string? n_banheiros { get; set; }
        public string? n_vagas { get; set; }
        public string? valor_condominio { get; set; }
        public string? valor_iptu { get; set; }
        public string? deseja { get; set; }
        public string? email_lead { get; set; }
        public string? fonte { get; set; }
        public int? qtd_registros { get; set; }
        public double? indice_dados { get; set; }
        public double? range_max { get; set; }
        public double? range_min { get; set; }
        public double? indice_localizacao { get; set; }
        public string? nome_lead { get; set; }
        public string? telefone_lead { get; set; }
        public double? vlmetro { get; set; }
        public double? vlim { get; set; }
        public double? vlc { get; set; }
        public string? geolocalizacao { get; set; }
        public int? avaliacao { get; set; }
        public string? valor_esperado { get; set; }
        public Boolean lead_enviado { get; set; }




    }
}
