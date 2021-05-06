#pragma checksum "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Widget\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89396918f0ee8eb141b3d1bdc408ef0204223d96"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89396918f0ee8eb141b3d1bdc408ef0204223d96", @"/Views/Widget/Index.cshtml")]
    public class Views_Widget_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CalculadoraDataImob.Models.EnderecosModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Widget\Index.cshtml"
  
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
        <div class=""row"" id=""a3"">
            <div class=""col-12""><h4 class=""mt-2 text-center"" id=""TituloWidget"">O que deseja saber:</h4></div>


            <div class=""col-12 mb-2"">
                <div class=""form-group d-grid mx-auto"">
                    <button type=""button"" class=""btn btn-outline-secondary text-align"" id=""btnaluguel""><i class=""far fa-chart-bar""></i> Quanto vale meu Aluguel?</button>
                </div>
            </div>


            <div class=""col-12"">
                <div class=""form-group d-grid mx-auto"">
                    <button type=""button"" class=""btn btn-outline-secondary text-align"" id=""btnimovel""><i class=""far fa-chart-bar""></i> Quanto vale meu Imóvel?</button>
                </div>
            </div>
        </div>
    </div>

    <!-- SEGUNDA QUESTÃO -->
    <div id=""SegundoDiv"" class=""Segunda");
            WriteLiteral(@"Questao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">
            <!-- Conteúdodo card -->

            <div class=""col-12""><h4 class=""mt-2 text-center "" id=""pergunta2"">Qual o tipo de Imóvel?</h4></div>


            <div class=""col-12"">
                <div class=""form-group d-grid mx-auto mb-2"">
                    <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Apartamento"" id=""btnAp""><i class=""fas fa-building""></i> Apartamento</button>
                </div>
            </div>


            <div class=""col-12"">
                <div class=""form-group d-grid mx-auto mb-2"">
                    <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Casa"" id=""btnCasa""><i class=""fas fa-home""></i> Casa</button>
                </div>
            </div>


            <div class=""col-12"">
                <div class=""form-group d-grid mx-auto mb-2"">
                    <button type=""button"" class=""btn btn-outline-secondary");
            WriteLiteral(@" text-align"" value=""Comercial"" id=""btComercial""><i class=""fas fa-industry""></i> Comercial</button>
                </div>
            </div>


            <div class=""col-12"">
                <div class=""form-group d-grid mx-auto"">
                    <button type=""button"" class=""fadeIn fourth btn btn-outline-secondary"" value=""Voltar"" id=""Voltar2""><i class=""fas fa-angle-double-left""></i> Voltar</button>
                </div>
            </div>
        </div>
    </div>

    <!-- TERCEIRA QUESTÃO -->
    <div id=""terceiraDiv"" class=""TerceiraQuestao"">
        <!-- Estrutura do card -->
        <div class=""row search-input"">
            <div id=""formContentQ03"" class=""formContent"">
                <!-- Conteúdodo card -->
                <h4 class=""mt-2 text-center "">Qual o bairro do imóvel ?</h4>
                <div class=""row mb-2"">
                    <div class=""col-12"">
                        <div id=""infoListaEnderecos"">
                            <small>*Selecione um Bairro suge");
            WriteLiteral(@"rido da lista</small>
                        </div>
                        <input autocomplete=""off"" type=""text"" id=""Endereco"" class=""form-control"">
                        <div class=""autocom-box"" style=""  max-height: 150px; "">
                            <!-- here list are inserted from javascript -->
                        </div>
                    </div>
                </div>

                <div class=""row mb-2"">
                    <div class=""col-6 d-grid mx-auto"">
                        <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar3""><i class=""fas fa-angle-double-left""></i> Voltar</button>
                    </div>
                    <div class=""col-6 d-grid mx-auto"">
                        <button type=""button"" class=""btn btn-secondary text-align"" value=""Próximo"" id=""Proximo3"">Próximo <i class=""fas fa-angle-double-right""></i></button>
                    </div>
                </div>
            </div>
        </div>
    </di");
            WriteLiteral(@"v>

    <!-- Quarta QUESTÃO -->
    <div id=""quartaDiv"" class=""QuartaQuestao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">


            <!-- Conteúdodo card -->
            <h5 class=""mt-2 text-center "">Qual a área aproximada (m²)?</h5>


            <div class=""form-group mb-2"">
                <input type=""number"" id=""areaAproximada"" class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 4633, "\"", 4640, 0);
            EndWriteAttribute();
            WriteLiteral(@" min=""0"">
            </div>

            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar4""><i class=""fas fa-angle-double-left""></i> Voltar</button>
            </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-secondary text-align"" value=""Próximo"" id=""Proximo4"">Próximo <i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>

    <!-- Quinta QUESTÃO -->
    <div id=""quintaDiv"" class=""QuintaQuestao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">
            <div class=""col-12"" id=""a4""></div>

            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center "">Nº de quartos no total:</h4>
            <div class=""col-12"" id=""a4""></div>

            <div class=""row mb-2"">
                <div class=""col-1""></div>
                <div class=""col-2"">
                 ");
            WriteLiteral(@"   <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""1"" name=""quartos"" value=""1"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""1"">1</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""2"" name=""quartos"" value=""2"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""2"">2</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""3"" name=""quartos"" value=""3"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""3"">3</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-");
            WriteLiteral(@"check-inline"">
                        <input type=""radio"" id=""4"" name=""quartos"" value=""4"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""4"">4</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""5"" name=""quartos"" value=""5"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""5"">5</label>
                    </div>
                </div>
            </div>
            <div class=""col-1""></div>

            <div class=""col-12"" id=""a4""></div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar5""><i class=""fas fa-angle-double-left""></i> Voltar</button>
            </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-");
            WriteLiteral(@"secondary text-align"" value=""Proximo"" id=""Proximo5"">Próximo <i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>


    <!-- Sexta QUESTÃO -->
    <div id=""sextaDiv"" class=""SextaQuestao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">

            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center "">Nº de banheiros no total:</h4>


            <div class=""row mb-2"">
                <div class=""col-1""></div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""1"" name=""banheiros"" value=""1"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""1"">1</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""2"" name=""banheiros"" value=""2"" class=");
            WriteLiteral(@"""form-check-input"" style=""cursor: pointer;"">
                        <label for=""2"">2</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""3"" name=""banheiros"" value=""3"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""3"">3</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""4"" name=""banheiros"" value=""4"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""4"">4</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""5"" name=""banheiros"" value=""5"" class=""form-check-input"" style=");
            WriteLiteral(@"""cursor: pointer;"">
                        <label for=""5"">5</label>
                    </div>
                </div>
                <div class=""col-1""></div>
            </div>


            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar6""><i class=""fas fa-angle-double-left""></i> Voltar</button>
            </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-secondary text-align"" value=""Proximo"" id=""Proximo6"">Próximo <i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>

    <!-- Sétima QUESTÃO -->
    <div id=""setimaDiv"" class=""SetimaQuestao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">


            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center "">Nº de vagas na garagem:</h4>


            <div class=""row mb-2"">
                <div class=""col-");
            WriteLiteral(@"1""></div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""1"" name=""garagem"" value=""1"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""1"">1</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""2"" name=""garagem"" value=""2"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""2"">2</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""3"" name=""garagem"" value=""3"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""3"">3</label>
                    </div>
                </div>
                <div");
            WriteLiteral(@" class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""4"" name=""garagem"" value=""4"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""4"">4</label>
                    </div>
                </div>
                <div class=""col-2"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" id=""5"" name=""garagem"" value=""5"" class=""form-check-input"" style=""cursor: pointer;"">
                        <label for=""5"">5</label>
                    </div>
                </div>
                <div class=""col-1""></div>
            </div>



            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar7""><i class=""fas fa-angle-double-left""></i> Voltar</button>
            </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type");
            WriteLiteral(@"=""button"" class=""btn btn-secondary text-align"" value=""Proximo"" id=""Proximo7"">Próximo <i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>

    <!-- Oitava QUESTÃO -->
    <div id=""oitavaDiv"" class=""oitavaQuestao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">


            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center "">Qual o valor do condomínio?</h4>


            <div class=""form-group mb-2"">
                <input type=""text"" class=""form-control"" id=""valorCondominio"">
            </div>


            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar8""><i class=""fas fa-angle-double-left""></i> Voltar</button>
            </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-secondary text-align"" value=""Proximo"" id=""Proximo8"">Próximo <i class=""fas fa-angle-");
            WriteLiteral(@"double-right""></i></button>
            </div>
        </div>
    </div>

    <!-- Nona QUESTÃO -->
    <div id=""nonaDiv"" class=""nonaQuestao"">
        <!-- Estrutura do card -->
        <div class=""row"" id=""a3"">

            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center "">Qual o valor total do IPTU?</h4>


            <div class=""form-group mb-2"">
                <input type=""text"" class=""form-control"" id=""valorIPTU"">
            </div>



            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar9""><i class=""fas fa-angle-double-left""></i> Voltar</button>
            </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-secondary text-align"" value=""Proximo"" id=""Proximo9"">Próximo <i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>

    <!-- Décima QUESTÃO -->
    <div id=");
            WriteLiteral(@"""decimaDiv"" class=""decimaDiv"">
        <!-- Estrutura do card -->
        <div class=""row px-2"" id=""a3"">

            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center "">Você Deseja: </h4>


            <input type=""button"" class=""btn btn-outline-secondary mb-2""");
            BeginWriteAttribute("value", " value=\"", 15166, "\"", 15174, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btnDeseja1\">\r\n\r\n\r\n            <input type=\"button\" class=\"btn btn-outline-secondary mb-2\"");
            BeginWriteAttribute("value", " value=\"", 15269, "\"", 15277, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""btnDeseja2"">


            <button type=""button"" class=""btn btn-outline-secondary "" value=""Voltar"" id=""Voltar10""><i class=""fas fa-angle-double-left""></i> Voltar</button>
        </div>
    </div>

    <!-- Décima Primeira QUESTÃO -->
    <div id=""decimaPDiv"" class=""decimaPDiv"">
        <!-- Estrutura do card -->
        <div class=""row px-2"" id=""a3"">
            <!-- Conteúdodo card -->
            <h4 class=""mt-2 text-center ""></h4>


            <input name=""nome"" type=""text"" class=""form-control mb-2"" id=""valorNome"" placeholder=""Nome"">


            <input name=""email"" type=""email"" class=""form-control mb-2"" id=""valorEmail"" placeholder=""E-mail"">


            <input name=""telefone"" type=""text"" class=""form-control mb-2"" id=""valorTelefone"" placeholder=""Telefone"">

            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-outline-secondary text-align"" value=""Voltar"" id=""Voltar11""><i class=""fas fa-angle-double-left""></i> Voltar</button>
    ");
            WriteLiteral(@"        </div>
            <div class=""col-6 d-grid mx-auto"">
                <button type=""button"" class=""btn btn-secondary text-align"" value=""Próximo"" id=""Proximo11"">Enviar <i class=""fas fa-angle-double-right""></i></button>
            </div>
        </div>
    </div>

    <!-- RESULTADO FINAL -->
    <div class=""ResultadosFinais"">
        <div class=""row"">
            <div class=""card-header py-0"">
                <!--style=""padding: .75rem 4rem;""-->
                <ul class=""nav nav-tabs mb-0 text-center"" id=""bologna-list"" role=""tablist"">
                    <li class=""nav-item col-6 d-grid mx-auto"">
                        <a class=""nav-link active"" href=""#description"" role=""tab"" aria-controls=""description"" aria-selected=""true"" style=""color: black;"">Resultado</a>
                    </li>
                    <li class=""nav-item col-6 d-grid mx-auto"">
                        <a class=""nav-link "" href=""#history"" role=""tab"" aria-controls=""history"" aria-selected=""false"" style=""color: black;");
            WriteLiteral(@""" >Dados</a>
                    </li>
                </ul>
            </div>
            <div class=""card-body px-3"">
                <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""description"" role=""tabpanel"">
                        <div class=""container-fluid p-0"">
                            <!-- Resultado -->
                            <div id=""resultadoDiv"" class=""CardsResultados"">
                                <!-- Estrutura do card -->
                                <h6 class=""ValoresTxt mb-1"">Valor do Metro Quadrado:</h6>
                                <h5 class=""valoresResult"" id=""valorMQ""></h5>
                            </div>

                            <hr>

                            <div id=""resultadoDiv2"" class=""CardsResultados"">
                                <h6 class=""ValoresTxt mb-1"" id=""txtResultado2""></h6>
                                <h5 class=""valoresResult"" id=""valorIA""></h5>
                            </div>

    ");
            WriteLiteral(@"                        <hr>

                            <div id=""resultadoDiv3"" class=""CardsResultados"">
                                <h6 class=""ValoresTxt mb-1"">Valor do Condomínio para Imóveis semelhantes:</h6>
                                <h5 class=""valoresResult"" id=""valorSemelhante""></h5>
                            </div>
                        </div>
                    </div>

                    <div class=""tab-pane"" id=""history"" role=""tabpanel"" aria-labelledby=""history-tab"">
                        <table class=""table table-striped fs-6"">
                            <tbody>
                                <tr>
                                    <td colspan=""2""><span>Imóvel:</span> <span id=""resposta1""></span></td>
                                </tr>

                                <tr>
                                    <td colspan=""2""><span>Localização:</span> <span id=""resposta2""></span></td>
                                </tr>

                                <");
            WriteLiteral(@"tr>
                                    <td><span>Área aproximada:</span></td>
                                    <td><span id=""resposta3""></span></td>
                                </tr>

                                <tr>
                                    <td><span>Qtd. Quartos:</span></td>
                                    <td><span id=""resposta4""></span></td>
                                </tr>

                                <tr>
                                    <td><span>Qtd. Banheiros:</span></td>
                                    <td><span id=""resposta5""></span></td>
                                </tr>

                                <tr>
                                    <td><span>Qtd. Vagas:</span></td>
                                    <td><span id=""resposta6""></span></td>
                                </tr>

                                <tr>
                                    <td><span>Valor condomínio:</span></td>
                               ");
            WriteLiteral(@"     <td><span id=""resposta7""></span></td>
                                </tr>

                                <tr>
                                    <td><span>Valor IPTU:</span></td>
                                    <td><span id=""resposta8""></span></td>
                                </tr>

                                <!--<tr>
                                    <td><i class=""fas fa-vector-square""></i> <span id=""resposta3""></span></td>
                                    <td><i class=""fas fa-bed""></i> <span id=""resposta4""></span></td>
                                </tr>

                                <tr>
                                    <td><i class=""fas fa-toilet""></i> <span id=""resposta5""></span></td>
                                    <td><i class=""fas fa-warehouse""></i> <span id=""resposta6""></span></td>
                                </tr>

                                <tr>
                                    <td><i class=""fas fa-hand-holding-usd""></i> <span i");
            WriteLiteral(@"d=""resposta7""></span></td>
                                    <td><i class=""fas fa-file-invoice-dollar""></i> <span id=""resposta8""></span></td>
                                </tr>-->
                            </tbody>
                        </table>
                    </div>

                    <div id=""resultadoDiv4"" class="" fadeInDownPR"">
                        <div class=""row text-center "">
                            <div class=""col-md-12 mt-1"">
                                <button type=""button"" class=""btn btn-secondary text-align"" value=""NOVA AVALIAÇÃO"" id=""botaoNV""><i class=""fas fa-search-dollar""></i> NOVA AVALIAÇÃO</button>
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
