using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataImob.Model
{
    public class CalculoDataImobModel
    {
      
        [Keyless]
        public class DadosFormularioModel
        {  
            public int valor_metro  { get; set; }
            public int valor_imovel { get; set; }
            public int valor_condominio { get; set; }
            public int qtd_registros { get; set; }
            public int indice_dados { get; set; }

        }
    }
}
