using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using ApiDataImob.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace ApiDataImob.Controllers
{
    public class ParceiroRegistroController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        private readonly RequisicaoWidgetContext _context;

        public ParceiroRegistroController(RequisicaoWidgetContext context)
        {
            _context = context;
        }

       


        [Authorize]
        //POST: requisicao
        [HttpPost]
        public string requisicao([FromBody] dynamic forms)
        {
            int leads_max=20;
            JObject objeto = JObject.Parse(forms.ToString());
            var nome = objeto.SelectToken("nome").ToString();
            var email = objeto.SelectToken("email").ToString();
            var telefone = objeto.SelectToken("telefone").ToString();
            var nomeEmpresa = objeto.SelectToken("nomeEmpresa").ToString();
            var siteEmpresa = objeto.SelectToken("siteEmpresa").ToString();
            var cupomDesconto = objeto.SelectToken("cupomDesconto").ToString();
            var cidadeEmpresa = objeto.SelectToken("cidadeEmpresa").ToString();
            var estadoEmpresa = objeto.SelectToken("estadoEmpresa").ToString(); 
            //Aplica codigo promocional
            if (cupomDesconto== "GROUP50")
            {
                leads_max = 50;
            }

             string script = "select * from empresa_parceira where email='"+email+"'";
            var parceira = _context.RequisicaoWidgetModel
                .FromSqlRaw(script)
                .ToList();
            //== a 0 não achou
        

            if (parceira.Count() == 0)
            {
                var Requisicao = new RequisicaoWidgetModel
                {
                    nome = nome,
                    email = email,
                    telefone = telefone,
                    nome_empresa = nomeEmpresa,
                    site_empresa = siteEmpresa,
                    leads_max = leads_max,
                    cidade = cidadeEmpresa,
                    estado = estadoEmpresa,
                    envio_email = true
                };

                _context.Add<RequisicaoWidgetModel>(Requisicao);
                _context.SaveChanges();
                var empresa = _context.RequisicaoWidgetModel
               .FromSqlRaw(script)
               .ToList();
                enviarEmail(empresa.ElementAt(0).nome_empresa.ToString(),email, empresa.ElementAt(0).id_empresa.ToString());
                return "1";
            }
            else
            {
                return "0";
            }
          
        }

        private void enviarEmail(string nome_empresa, string email, string id)
        {


            string text = "<!DOCTYPE html><html lang=\"pt-br\"><head>    <meta charset=\"UTF-8\">    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">    <title></title></head><body>    <div    style=\"clear: both; color: #474747 ;max-width: 950px; margin: 0 auto; text-align: center; font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;\">    <!-- HEADER -->    <div style=\"border-left: solid 20px #1c85c7; border-right: solid 20px #ffc107; text-align: left; padding: 20px;\">        <div style=\"float: left;\"> <a title=\"www.dataimob.com.br\" href=\"http://www.dataimob.com.br\" target=\"_blank\">                <img src=\"https://dataimob.com.br/Imagens/logo_data.png\" width=\"100px\" style=\"padding: 10px;\"> </a>        </div>        <div style=\"text-align: center;\">            <h1 style=\"color: #1c85c7; padding: 10px; margin: 0px; font-weight: bold;padding-top: 15px;\">Olá #NOMEPARCEIRO#, seja bem-vindo!</h1>        </div>    </div> <!-- HEADER -->    <!-- CONTENT -->    <div        style=\"margin-top: 5px; border-left: solid 20px #1c85c7; border-right: solid 20px #ffc107;  padding: 20px 0px;\">        <div style=\"margin: 20px 40px; \">            <p style=\"margin: 20px 0px; padding: 20px;text-align: justify;\">Agora que você já se cadastrou no DataImob, basta escolher a                melhor forma de utilizar nosso Widget.</p>            <h3                style=\"z-index: 99999; color: #fff; background: #1c85c7; padding: 30px; font-weight: normal; margin: 20px 0px;\">                Essse é seu ID DataImob: <span style=\"font-weight: bold; color: #ffc107;     font-size: 150%;\">                    #IDEMPRESA# </span> | Email cadastrado: <span                    style=\"font-weight: bold; color: #ffc107;  text-decoration: none;   font-size: 150%;\">                    #EMAILEMPRESA# </span></h3>            <p style=\"padding: 20px;  margin: 20px  0px; text-align: justify;\">É o <span style=\"font-weight: bold;\">ID DataImob</span> que                permite nossa ferramenta te indentificar e enviar corretamente os dados dos leads para o email                cadastrado! <br><br> Caso deseje alterar o email que irá receber os leads, entre em contato conosco pelo email:                <a title=\"contato@dataimob.com.br\" href=\"mailto:contato@dataimob.com.br\">contato@dataimob.com.br</a>.            </p>        </div>        <h2 style=\"margin: 0 40px; background: #ffc107; color: #1c85c7; padding: 20px;\">Siga as instruções para integrar nosso widget:</h2>        <div style=\"margin: 0 40px; background: #b3d8ef; padding: 10px; text-align: left;\">            <h3><span                style=\"border-radius: 45%; background: #ffc107; color: #1c85c7; padding: 5px 10px; margin: 15px;\">1</span>Copie            o nosso script personalizado que está abaixo.</h3>            <div style=\"padding-left: 15px;padding-right: 15px;padding-bottom: 2px;padding-top: 2px;\">                              <div                    style=\"background: #fff; padding: 40px; border: 1px #1c85c7 dashed; color: #1c85c7; font-size: 80%; text-align: center;\">                    &lt;script id=&quot;DataImobScript&quot;                    src=&quot;https://dataimob.com.br/widget/js/app.js?id=#IDEMPRESA#&quot;&gt;&lt;/script&gt; </div>            </div>            <div>                <h3><span                        style=\"border-radius: 45%; background: #ffc107; color: #1c85c7; padding: 5px 10px; margin: 15px;\">2</span>Cole                    o script no código fonte do seu site.</h3>            </div>            <div>                <h3><span                        style=\"border-radius: 45%; background: #ffc107; color: #1c85c7; padding: 5px 10px; margin: 15px;\">3</span>Pronto!                    A ferramenta DataImob está integrada ao seu site!</h3>            </div>        </div>        <div style=\"margin: 40px; text-align: justify;\" >            <p>Em casos de dúvida, entre em contato pelo email: <a title=\"contato@dataimob.com.br\"                    href=\"mailto:contato@dataimob.com.br\">contato@dataimob.com.br</a>.</p>            <p>Caso seja um usuário avançado e deseja ver as outras formas de integrar a ferramenta da DataImob com o                seu portal, <a title=\"Ver integração avançada\" href=\"http://www.dataimob.com.br/integracaoavancada\"                    target=\"_blank\">clique aqui!</a>.</p>        </div>    </div> <!-- CONTENT -->    <!-- FOOTER -->    <div style=\"margin-top: 5px; padding: 20px; border-left: solid 20px #1c85c7; border-right: solid 20px #ffc107;\"> <a            title=\"www.dataimob.com.br\" href=\"http://www.dataimob.com.br\" target=\"_blank\"> <img                src=\"https://dataimob.com.br/Imagens/rodape_data.png\" width=\"100px\"> </a> </div> <!-- FOOTER --></div></body></html>";
            var htmlemail = text.Replace("#IDEMPRESA#", id).Replace("#EMAILEMPRESA#", email).Replace("#NOMEPARCEIRO#", nome_empresa);

            //configuração do email
            SmtpClient smtpClient = new SmtpClient("email-smtp.us-east-1.amazonaws.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("AKIA37QAZKZBZXVCJI4G", "BPQObUgCi8gSj+/GZtqSn9T+l7c2YoohyQcXewws7hAc");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();
            
            //De, para
            mail.From = new MailAddress("contato@dataimob.com.br", "DataImob");
            mail.To.Add(new MailAddress(email));
            
            //Corpo do email
            mail.IsBodyHtml = true; //define a formatação do corpo como html
            mail.Subject = "DataImob - Instruções de uso Widget";
            mail.Body = htmlemail;
            smtpClient.Send(mail);
        }

    }
}
