#pragma checksum "C:\Users\fernando.bretz\Documents\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Widget\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c946e94e7c9428acb5b2f00c183c493f9b527839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Widget_Index), @"mvc.1.0.view", @"/Views/Widget/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c946e94e7c9428acb5b2f00c183c493f9b527839", @"/Views/Widget/Index.cshtml")]
    public class Views_Widget_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CalculadoraDataImob.Models.EnderecosModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\fernando.bretz\Documents\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Widget\Index.cshtml"
  
    ViewData["Data Imob"] = "Widget";
    Layout = "_LayoutWidget";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- INICIO DO FORMS  -->
<form>
    <!-- PRIMEIRA QUESTÃO -->
    <div id=""PrimeiraDiv"" class=""PrimeiraQuestao"">
        <!-- Estrutura do card -->

        <div class='row justify-content-center align-content-start' id='a3'>

            <H1 id=""TituloWidget"">
                <p id=""p1"">O que deseja saber:</p>
            </H1>

            <div class='col-12' id='a4'></div>
            <input type=""button"" class=""fadeIn fourth  botaoacao"" value=""Quanto vale meu aluguel?""
                   id=""btnaluguel"">

            <div class='col-12' id='a4'></div>

            <input type=""button"" class=""fadeIn fourth botaoacao"" value=""Quanto vale meu Imóvel?  ""
                   id=""btnimovel"">



        </div>
    </div>

    <!-- SEGUNDA QUESTÃO -->
    <div id=""SegundoDiv"" class=""SegundaQuestao"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <!-- Conteúdodo card -->
            <div class='col-12' ");
            WriteLiteral(@"id='a4'></div>

            <p id=""pergunta2"">Qual o tipo de imóvel?</p>
            <div class='col-12' id='a4'></div>

            <input type=""button"" class=""fadeIn fourth  botaoacao"" value=""🏢 Apartamento"" id=""btnAp"">
            <div class='col-12' id='a4'></div>

            <input type=""button"" class=""fadeIn fourth botaoacao"" value=""        🏠 Casa         "" id=""btnCasa"">
            <div class='col-12' id='a4'></div>

            <input type=""button"" class=""fadeIn fourth botaoacao"" value=""  🏪 Comercial   "" id=""btComercial"">
            <div class='col-12' id='a4'></div>

            <input type=""button"" class=""fadeIn fourth botaoVoltar1 "" value=""Voltar"" id=""Voltar2"">

        </div>


    </div>



    <!-- TERCEIRA QUESTÃO -->
    <div id=""terceiraDiv"" class=""TerceiraQuestao"">
        <!-- Estrutura do card -->
        <div class=""wrapper fadeInDown search-input"">
            <div id=""formContentQ03"" class=""formContent"">
                <!-- Conteúdodo card -->
         ");
            WriteLiteral(@"       <p>Qual o bairro do imóvel ?</p>
                <div id=""infoListaEnderecos"">
                    <small>*Selecione um Bairro sugerido da lista</small>
                </div>
                <input autocomplete=""off"" type=""text"" id=""Endereco"" class=""fadeInQ03 second"">
                <div class=""autocom-box"" style=""  max-height: 150px; "">
                    <!-- here list are inserted from javascript -->
                </div>

                <div class=""row"">

                    <div class=""col-sm-5"">
                        <input type=""button"" class=""fadeIn fourth botao "" value=""Proximo"" id=""Proximo3"">



                    </div>

                    <div class=""col-sm-5"">

                        <input type=""button"" class=""fadeIn fourth botaoVoltar "" value=""Voltar"" id=""Voltar3"">

                    </div>
                </div>

            </div>
        </div>
    </div>




    <!-- Quarta QUESTÃO -->
    <div id=""quartaDiv"" class=""QuartaQuestao"">
      ");
            WriteLiteral(@"  <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>

            <!-- Conteúdodo card -->
            <p>Qual a área aproximada (m²)?</p>
            <div class='col-12' id='a4'></div>

            <input type=""number"" id=""areaAproximada"" class=""fadeIn second""");
            BeginWriteAttribute("name", " name=\"", 3585, "\"", 3592, 0);
            EndWriteAttribute();
            WriteLiteral(@" min=""0"">


            <input type=""button"" class=""fadeIn fourth botao"" value=""Proximo"" id=""Proximo4"">

            <input type=""button"" class=""fadeIn fourth botaoVoltar"" value=""Voltar"" id=""Voltar4"">









        </div>
    </div>

    <!-- Quinta QUESTÃO -->
    <div id=""quintaDiv"" class=""QuintaQuestao"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>

            <!-- Conteúdodo card -->
            <p>Número de quartos no total:</p>
            <div class='col-12' id='a4'></div>

            <div class=""row"" style=""padding-left: 10%;"">

                <div class=""col-2"">

                    <input type=""radio"" id=""1"" name=""quartos"" value=""1"" class=""RadionQuarto"">
                    <label for=""1"">1</label><br>

                </div>

                <div class=""col-2"">

                    <input type=""radio"" id=""2"" name=""quartos"" value=""2"" class=""Ra");
            WriteLiteral(@"dionQuarto"">
                    <label for=""2"">2</label><br>

                </div>

                <div class=""col-2"">
                    <input type=""radio"" id=""3"" name=""quartos"" value=""3"" class=""RadionQuarto"">
                    <label for=""3"">3</label><br>

                </div>
                <div class=""col-2"">
                    <input type=""radio"" id=""4"" name=""quartos"" value=""4"" class=""RadionQuarto"">
                    <label for=""4"">4</label><br>

                </div>
                <div class=""col-2"">

                    <input type=""radio"" id=""5"" name=""quartos"" value=""5"" class=""RadionQuarto"">
                    <label for=""5"">5</label><br>

                </div>

            </div>



            <div class='col-12' id='a4'></div>


            <input type=""button"" class=""fadeIn fourth botao"" value=""Proximo"" id=""Proximo5"">

            <input type=""button"" class=""fadeIn fourth botaoVoltar"" value=""Voltar"" id=""Voltar5"">

        </div>
    </div>

  ");
            WriteLiteral(@"  <!-- Sexta QUESTÃO -->
    <div id=""sextaDiv"" class=""SextaQuestao"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>
            <!-- Conteúdodo card -->
            <p>Número de banheiros no total:</p>

            <div class='col-12' id='a4'></div>

            <div class=""row"" style=""padding-left: 10%;"">

                <div class=""col-2"">

                    <input type=""radio"" id=""1"" name=""banheiros"" value=""1"">
                    <label for=""1"">1</label><br>

                </div>

                <div class=""col-2"">

                    <input type=""radio"" id=""2"" name=""banheiros"" value=""2"">
                    <label for=""2"">2</label><br>

                </div>

                <div class=""col-2"">
                    <input type=""radio"" id=""3"" name=""banheiros"" value=""3"">
                    <label for=""3"">3</label><br>

                </div>
               ");
            WriteLiteral(@" <div class=""col-2"">
                    <input type=""radio"" id=""4"" name=""banheiros"" value=""4"">
                    <label for=""4"">4</label><br>

                </div>
                <div class=""col-2"">

                    <input type=""radio"" id=""5"" name=""banheiros"" value=""5"">
                    <label for=""5"">5</label><br>

                </div>

            </div>



            <div class='col-12' id='a4'></div>


            <input type=""button"" class=""fadeIn fourth botao"" value=""Proximo"" id=""Proximo6"">

            <input type=""button"" class=""fadeIn fourth botaoVoltar"" value=""Voltar"" id=""Voltar6"">








        </div>
    </div>


    <!-- Sétima QUESTÃO -->
    <div id=""setimaDiv"" class=""SetimaQuestao"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>

            <!-- Conteúdodo card -->
            <p>Número de vagas a garagem:</p>
            <");
            WriteLiteral(@"div class='col-12' id='a4'></div>

            <div class=""row"" style=""padding-left: 10%;"">

                <div class=""col-2"">

                    <input type=""radio"" id=""1"" name=""garagem"" value=""1"">
                    <label for=""1"">1</label>

                </div>

                <div class=""col-2"">

                    <input type=""radio"" id=""2"" name=""garagem"" value=""2"">
                    <label for=""2"">2</label>

                </div>

                <div class=""col-2"">
                    <input type=""radio"" id=""3"" name=""garagem"" value=""3"">
                    <label for=""3"">3</label>
                </div>

                <div class=""col-2"">
                    <input type=""radio"" id=""4"" name=""garagem"" value=""4"">
                    <label for=""4"">4</label>

                </div>
                <div class=""col-2"">

                    <input type=""radio"" id=""5"" name=""garagem"" value=""5"">
                    <label for=""5"">5</label>

                </div>

");
            WriteLiteral(@"            </div>


            <div class='col-12' id='a4'></div>



            <input type=""button"" class=""fadeIn fourth botao"" value=""Proximo"" id=""Proximo7"">

            <input type=""button"" class=""fadeIn fourth botaoVoltar"" value=""Voltar"" id=""Voltar7"">








        </div>

    </div>


    <!-- Oitava QUESTÃO -->
    <div id=""oitavaDiv"" class=""oitavaQuestao"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>

            <!-- Conteúdodo card -->
            <p>Qual o valor do condomínio?</p>
            <div class='col-12' id='a4'></div>

            <input type=""text"" class=""fadeIn second"" id=""valorCondominio"">

            <div class='col-12' id='a4'></div>



            <input type=""button"" class=""fadeIn fourth botao"" value=""Proximo"" id=""Proximo8"">


            <input type=""button"" class=""fadeIn fourth botaoVoltar"" value=""Voltar"" id=""Voltar8"">

            WriteLiteral(@"






        </div>
    </div>


    <!-- Nona QUESTÃO -->
    <div id=""nonaDiv"" class=""nonaQuestao"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>
            <!-- Conteúdodo card -->
            <p>Qual o valor total do IPTU?</p>
            <div class='col-12' id='a4'></div>

            <input type=""text"" class=""fadeIn second"" id=""valorIPTU"">



            <div class='col-12' id='a4'></div>


            <input type=""button"" class=""fadeIn fourth botao"" value=""Proximo"" id=""Proximo9"">


            <input type=""button"" class=""fadeIn fourth botaoVoltar"" value=""Voltar"" id=""Voltar9"">










        </div>
    </div>



    <!-- Décima QUESTÃO -->
    <div id=""decimaDiv"" class=""decimaDiv"">
        <!-- Estrutura do card -->
        <div class='row justify-content-center align-content-start' id='a3'>
            <div class='col-12' id='a4'></div>
            WriteLiteral("\n            <!-- Conteúdodo card -->\r\n            <p>Você Deseja: </p>\r\n            <div class=\'col-12\' id=\'a4\'></div>\r\n            <input type=\"button\" class=\"fadeIn fourth  botaoacao\"");
            BeginWriteAttribute("value", " value=\"", 10947, "\"", 10955, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btnDeseja1\">\r\n            <div class=\'col-12\' id=\'a4\'></div>\r\n            <input type=\"button\" class=\"fadeIn fourth botaoacao\"");
            BeginWriteAttribute("value", " value=\"", 11087, "\"", 11095, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""btnDeseja2"">
            <div class='col-12' id='a4'></div>
            <input type=""button"" class=""fadeIn fourth botaoVoltar1 "" value=""Voltar"" id=""Voltar10"">


        </div>

    </div>








    <!-- RESULTADO FINAL -->
    <div class=""ResultadosFinais"">


        <div class=""row"">
          
                <div class=""card-header "" style=""padding: .75rem 4rem;"">
                    <ul class=""nav nav-tabs card-header-tabs"" id=""bologna-list"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""#description"" role=""tab"" aria-controls=""description"" aria-selected=""true"">Resultado</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#history"" role=""tab"" aria-controls=""history"" aria-selected=""false"">Perguntas</a>
                        </li>

                    </ul>
                </div>
                <div class=""card");
            WriteLiteral(@"-body"">

                    <div class=""tab-content mt-3"">


                        <div class=""tab-pane active"" id=""description"" role=""tabpanel"">
                            <div class=""container"">

                                <!-- Resultado -->
                                <div id=""resultadoDiv"" class=""CardsResultados"">
                                    <!-- Estrutura do card -->
                                    <div class=""row text-right "">
                                        <div class=""col-md-6"">
                                            <h5 class=""ValoresTxt"">Valor do Metro Quadrado:</h5>
                                        </div>
                                        <div class=""col-md-6"">
                                            <h3 class=""valoresResult"" id=""valorMQ""></h3>

                                        </div>
                                    </div>
                                </div>

                                <div id=""resultado");
            WriteLiteral(@"Div2"" class=""CardsResultados"">



                                    <div class=""row text-right "">
                                        <div class=""col-md-6"">
                                            <h5 class=""ValoresTxt"" id=""txtResultado2""> </h5>
                                        </div>
                                        <div class=""col-md-6"">
                                            <h3 class=""valoresResult"" id=""valorIA""></h3>
                                        </div>
                                    </div>

                                </div>


                                <div id=""resultadoDiv3"" class=""CardsResultados"">
                                    <div class=""row text-right "">
                                        <div class=""col-md-6"">
                                            <h6 class=""ValoresTxt"">Valor do Condomínio para Imóveis semelhantes:</h6>
                                        </div>
                                        <");
            WriteLiteral(@"div class=""col-md-6"">
                                            <h3 class=""valoresResult"" id=""valorSemelhante""></h3>
                                        </div>
                                    </div>

                                </div>

                            </div>




                            </div>

                            <div class=""tab-pane"" id=""history"" role=""tabpanel"" aria-labelledby=""history-tab"">




                                <div class="" col-md-12"">
                                    <span class=""left"">Tipo de imóvel:</span><span class=""right"" id=""resposta1""></span>
                                </div>

                                <div class="" col-md-12"">
                                    <span class=""left"">Localização:</span><span class=""right"" id=""resposta2""></span>
                                </div>
                                <div class="" col-md-12"">
                                    <span class=""left"">Área aproximada:");
            WriteLiteral(@"</span><span class=""right"" id=""resposta3""></span>
                                </div>
                                <div class="" col-md-12"">
                                    <span class=""left"">Qtd. Quartos:</span><span class=""right"" id=""resposta4""></span>
                                </div>
                                <div class="" col-md-12"">
                                    <span class=""left"">Qtd. Banheiros:</span><span class=""right"" id=""resposta5""></span>
                                </div>
                                <div class="" col-md-12"">
                                    <span class=""left"">Qtd. Vagas:</span><span class=""right"" id=""resposta6""></span>
                                </div>
                                <div class="" col-md-12"">
                                    <span class=""left"">Valor condomínio:</span><span class=""right"" id=""resposta7""></span>
                                </div>
                                <div class="" col-md-12"">
   ");
            WriteLiteral(@"                                 <span class=""left"">Valor IPTU:</span><span class=""right"" id=""resposta8""></span>
                                </div>







                            </div>



                            <div id=""resultadoDiv4"" class="" fadeInDownPR"" >


                                <div class=""card-body"">
                                    <div class="" row text-center "">
                                        <div class=""col-md-12 "" style=""padding-top: 10px;"">
                                            <input type=""button"" class=""fadeIn fourth botaoNV "" value=""NOVA AVALIAÇÃO"" id=""botaoNV"">
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                </div>
            </div>


          



            <!-- RESULTADOS DO CALCULO -->











        </div>





</form>



 
");
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CalculadoraDataImob.Models.EnderecosModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591