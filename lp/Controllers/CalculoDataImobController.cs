using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDataImob.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Npgsql;

namespace ApiDataImob.Controllers
{
    public class CalculoDataImobController : Controller
    {
 
        // GET: Home
        public async Task<IActionResult> Index()
        {
            return View();
        }

            [Authorize]
           // GET: Data
           public IActionResult Calculo([FromBody] dynamic dados) {


            //Variavel de retorno
            string resultado = "";

            //Pegando dados do JSON
            JObject obj = JObject.Parse(dados.ToString());
            
           string p_operacao = obj.SelectToken("p_operacao").ToString();
            string p_tipo_imovel = obj.SelectToken("p_tipo_imovel").ToString();
            string p_bairro_label = obj.SelectToken("p_bairro_label").ToString();
            string p_cidade_label = obj.SelectToken("p_cidade_label").ToString();
            string p_estado_label = obj.SelectToken("p_estado_label").ToString();
            var p_area_aproximada = obj.SelectToken("p_area_aproximada").ToString();
            var p_qtd_quartos = obj.SelectToken("p_qtd_quartos").ToString();
            var p_qtd_banheiros = obj.SelectToken("p_qtd_banheiros").ToString();
            var p_qtd_vagas = obj.SelectToken("p_qtd_vagas").ToString(); 
            var p_valor_codominio = obj.SelectToken("p_valor_codominio").ToString();
            var p_valor_iptu = obj.SelectToken("p_valor_iptu").ToString();

            //Configuração de conexão
            //const string conection = "Host=192.168.49.44;Port=5432;Pooling=true;Database=gd_acolweb;User Id=dataimob;Password=group@123;";
            const string conection = "Server=dataimob-db.cphqjwdeluyn.us-east-1.rds.amazonaws.com;User Id=postgres; Password=0*wqa0f\\pkd%#)&=;Database=gd_acolweb;";
            //Criando objeto para Conexão
            NpgsqlConnection conn = new NpgsqlConnection(conection);
            //Abrindo conexão
            conn.Open();
            string script = "select * from dataImob_calc ('" + p_operacao + "', '" + p_tipo_imovel + "', '" + p_bairro_label + "', '" + p_cidade_label + "', '" + p_estado_label + "', " + p_area_aproximada + ", " + p_qtd_quartos + ", " + p_qtd_banheiros + ", " + p_qtd_vagas + "," + p_valor_codominio + ", " + p_valor_iptu + ")";
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(script, conn);
            // Execute the query and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows
            while (dr.Read())
            {
                resultado += dr[0].ToString() + ";";
                resultado += dr[1].ToString() + ";";
                resultado += dr[2].ToString() + ";";
                resultado += dr[3].ToString() + ";";
                resultado += dr[4].ToString() + ";";
                resultado += dr[5].ToString() + ";";
                resultado += dr[6].ToString() + ";";
                resultado += dr[7].ToString() + ";";
                resultado += dr[8].ToString() + ";";
                resultado += dr[9].ToString() + ";";
            }

            conn.Close();

            return Json(resultado + script);



        }
    }
}
