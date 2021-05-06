 //VARIAVEIS GLOBAIS
let respostas = {};
//Titulos
let titulos = ["Descubra o valor do seu aluguel",
    "Descubra o valor do seu imóvel",
    "Quanto vale meu aluguel?",
    "Quanto vale meu imóvel?",
    "Valor do Imóvel!",
    "Valor do Aluguel!",
    "Valor Minimo:",
    "Valor Máximo:"
  
];

//IdEMpresa
let idEmpresa;
//Variaveis de estilo
let header;
let txt;
//Key
let key = "";
var r = document.querySelector(':root');
//Avaliacao
var avaliacao;
var id_questionario;


function mostrarResultado(data) {
    var resultado = data.split(';')

    var vlmetro = parseInt(resultado[0]).toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })
    var vlim = parseInt(resultado[1]).toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })
    var vlc = parseInt(resultado[2]).toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })
    var vlmax = parseInt(resultado[8]).toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })
    var vlmin = parseInt(resultado[9]).toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })
    
    
    $("#valorMIN").text(vlmin);//Valor minimo
    $("#valorMAX").text(vlmax);//Valor maximoValor do Aluguel:
    $("#valorMQ").text(vlmetro);//Valor Metro
    $("#valorIA").text(vlim);//Valor imovel

    if (resultado[2] < 50 || respostas[1] === "Casa") {
       
        $("#linha_vlc").hide();
        $("#txt_vlm").css("width", "50%");

    }
    else {
    $("#valorSemelhante").text(vlc);//Valor Condominio
    }
    //Mostrando os Resultados Finais
    $(".ResultadosFinais").show();

    var qtd_registros = resultado[3];
    var indice_dados = resultado[4];
    var range_max = resultado[5];
    var range_min = resultado[6];
    var indice_localizacao = resultado[7];

    postRequest(qtd_registros, indice_dados, range_max, range_min, indice_localizacao, resultado[0], resultado[1], resultado[2]);
}

//SCRIPT QUESTÃO 01
$("#btnimovel").click(function () {
    //preenche lista
    lista();
    //Escondendo Titulos
    $("#Titulo").text(titulos[1]);
    //Atribuindo Valor
    respostas[0] = "imovel";
    //Mostrando e escondendo perguntas
    $("#PrimeiraDiv").hide();
    $("#SegundoDiv").show();
    //Texto Do resultado no segundo card
    $("#txt_titulo").text(titulos[4])
    $("#txtResultado3").text(titulos[6])
    $("#txtResultado4").text(titulos[7])
 
  
    $("#btnDeseja1").prop('value', "Comprar um imóvel");
    $("#btnDeseja2").prop('value', "Vender um imóvel");
}); //FimProximoQuestao01

$("#btnaluguel").click(function () {
    //preenche lista
    lista();
    //Escondendo Titulos
    $("#Titulo").text(titulos[0]);
    //Atribuindo Valor
    respostas[0] = "aluguel";
    //Mostrando e escondendo perguntas
    $("#PrimeiraDiv").hide();
    $("#SegundoDiv").show();
    //Texto Do resultado no segundo card
    $("#txt_titulo").text(titulos[5]);
    $("#txtResultado3").text(titulos[6]);
    $("#txtResultado4").text(titulos[7]);
 

    $("#btnDeseja1").prop('value', "Achar um imóvel para alugar");
    $("#btnDeseja2").prop('value', "Disponibilizar um imóvel para alugar");
}); //FimProximoQuestao01

//SCRIPT QUESTÃO 02
$("#btnAp").click(function () {
    //Atribuindo Valor
    respostas[1] = "Apartamento";
    //Mostrando e escondendo perguntas
    $("#SegundoDiv").hide();
    $("#terceiraDiv").show();
}); //FimProximoQuestao01

$("#btnCasa").click(function () {
    //Atribuindo Valor
    respostas[1] = "Casa";
    //Mostrando e escondendo perguntas
    $("#SegundoDiv").hide();
    $("#terceiraDiv").show();
}); //FimProximoQuestao01

$("#btComercial").click(function () {
    //Atribuindo Valor
    respostas[1] = "Comercial";
    //Mostrando e escondendo perguntas
    $("#SegundoDiv").hide();
    $("#terceiraDiv").show();
}); //FimProximoQuestao01

//SCRIPT QUESTÃO 02
$("#Proximo2").click(function () {
    respostas[1] = $("#SelectQ02").val();
}); //FimProximoQuestao02

//BOTÃO VOLTAR 2 
$("#Voltar2").click(function () {
    $("#Titulo").text("");
    $("#PrimeiraDiv").show();
    $("#SegundoDiv").hide();
}); //FimProximoQuestao02

//SCRIPT QUESTÃO 03
$("#Proximo3").click(function () {
    const formBox = document.querySelector('#formContentQ03');
    const inputField = document.querySelector('#Endereco');
    const caixa = document.querySelector('#terceiraDiv');

    if (($("#Endereco").val().trim() != "") && naLista($("#Endereco").val()) == true) {
        respostas[2] = $("#Endereco").val();
        $("#terceiraDiv").hide();
        $("#quartaDiv").show();
    }
    else {
        $(".progress-bar").css("background-color", "#e21d2a");
        $("#infoListaEnderecos").show();
        inputFail(formBox, inputField, caixa);
    }

}); //FimProximoQuestao03

//BOTÃO VOLTAR 3
$("#Voltar3").click(function () {
    $("#SegundoDiv").show();
    $("#infoListaEnderecos").hide();
    $("#terceiraDiv").hide();
}); //FimProximoQuestao03

//SCRIPT QUESTÃO 04
$("#Proximo4").click(function () {
    const formBox = document.querySelector('#formContentQ04');
    const inputField = document.querySelector('#areaAproximada');
    const caixa = document.querySelector('#quartaDiv');

    if ($("#areaAproximada").val().trim() != "" && $("#areaAproximada").val() > 0) {
        respostas[3] = $("#areaAproximada").val();
        $("#quartaDiv").hide();
        $("#quintaDiv").show();
    }
    else {
        $(".progress-bar").css("background-color", "#e21d2a");
        $("#infoListaEnderecos").hide();
        inputFail(formBox, inputField, caixa);
    }
}); //FimProximoQuestao04

//BOTÃO VOLTAR 4
$("#Voltar4").click(function () {
    $("#infoListaEnderecos").hide();
    $("#terceiraDiv").show();
    $("#quartaDiv").hide();
}); //FimProximoQuestao04

//SCRIPT QUESTÃO 05
$("#Proximo5").click(function () {
    const formBox = document.querySelector('#formContentQ05');
    const inputField = $("input:radio[name ='quartos']:checked");
    const caixa = document.querySelector('#quintaDiv');

    if ($("input:radio[name ='quartos']:checked").val() != null) {
        respostas[4] = $("input:radio[name ='quartos']:checked").val();
        $("#quintaDiv").hide();
        $("#sextaDiv").show();
    }
    else {
        inputFail(formBox, inputField, caixa);
    }
}); //FimProximoQuestao05

//BOTÃO VOLTAR 5
$("#Voltar5").click(function () {
    $("#quintaDiv").hide();
    $("#quartaDiv").show();

}); //FimProximoQuestao05

//SCRIPT QUESTÃO 06
$("#Proximo6").click(function () {
    const formBox = document.querySelector('#formContentQ06');
    const inputField = $("input:radio[name ='banheiros']:checked");
    const caixa = document.querySelector('#sextaDiv');

    if ($("input:radio[name ='banheiros']:checked").val() != null) {
        respostas[5] = $("input:radio[name ='banheiros']:checked").val();
        $("#sextaDiv").hide();
        $("#setimaDiv").show();
    }
    else {
        $(".progress-bar").css("background-color", "#e21d2a");
        inputFail(formBox, inputField, caixa);
    }
    // $("#sextaDiv").show();
}); //FimProximoQuestao04

//BOTÃO VOLTAR 6
$("#Voltar6").click(function () {
    $("#sextaDiv").hide();
    $("#quintaDiv").show();
}); //FimProximoQuestao06

//SCRIPT QUESTÃO 07
$("#Proximo7").click(function () {
    const formBox = document.querySelector('#formContentQ07');
    const inputField = $("input:radio[name ='garagem']:checked");
    const caixa = document.querySelector('#setimaDiv');

    if ($("input:radio[name ='garagem']:checked").val() != null) {
        respostas[6] = $("input:radio[name ='garagem']:checked").val();
        $("#setimaDiv").hide();
        $("#oitavaDiv").show();
    }
    else {
        $("input:radio[name ='garagem']:checked").css("border-color", "#e21d2a");
        $("#Proximo7").css("background-color", "#e21d2a");
        $("#Voltar7").css("background-color", "#e21d2a");
        $("#Voltar7").css("color", "white");

        $(".progress-bar").css("background-color", "#e21d2a");
        inputFail(formBox, inputField, caixa);
    }
}); //FimProximoQuestao07

//BOTÃO VOLTAR 7
$("#Voltar7").click(function () {
    $("#setimaDiv").hide();
    $("#sextaDiv").show();
}); //FimProximoQuestao07

//SCRIPT QUESTÃO 08
$("#Proximo8").click(function () {
    const formBox = document.querySelector('#formContentQ08');
    const inputField = document.querySelector('#valorCondominio');
    const caixa = document.querySelector('#oitavaDiv');

    if ($("#valorCondominio").val().trim() != "") {
        respostas[7] = $("#valorCondominio").val();
        $("#oitavaDiv").hide();
        $("#nonaDiv").show();
    }
    else {
        $("#valorCondominio").css("border-color", "#e21d2a");
        $("#Proximo8").css("background-color", "#e21d2a");
        $("#Voltar8").css("background-color", "#e21d2a");
        $("#Voltar8").css("color", "#717171");
        $("#Voltar8").css("color", "white");
        $(".progress-bar").css("background-color", "#e21d2a");
        inputFail(formBox, inputField, caixa);
    }
}); //FimProximoQuestao08

//BOTÃO VOLTAR 8
$("#Voltar8").click(function () {
    $("#setimaDiv").show();
    $("#oitavaDiv").hide();
}); //FimProximoQuestao08

//SCRIPT QUESTÃO 09
$("#Proximo9").click(function () {
    const formBox = document.querySelector('#formContentQ09');
    const inputField = document.querySelector('#valorIPTU');
    const caixa = document.querySelector('#nonaDiv');

    if ($("#valorIPTU").val().trim() != "") {
        respostas[8] = $("#valorIPTU").val();
        $("#nonaDiv").hide();
        $("#decimaDiv").show();
    }
    else {
        $("#valorIPTU").css("border-color", "#e21d2a");
        $("#Proximo9").css("background-color", "#e21d2a");
        $("#Voltar9").css("background-color", "#e21d2a");
        $("#Voltar9").css("color", "#717171");
        $("#Voltar9").css("color", "white");
        $(".progress-bar").css("background-color", "#e21d2a");
        inputFail(formBox, inputField, caixa);
    }
}); //FimProximoQuestao09

//BOTÃO VOLTAR 9
$("#Voltar9").click(function () {
    $("#oitavaDiv").show();
    $("#nonaDiv").hide();
}); //FimProximoQuestao09

//SCRIPT QUESTÃO 10
$("#btnDeseja1").click(function () {
    //Atribuindo Valor
    respostas[9] = $(this).val();
    //Mostrando e escondendo perguntas
    $("#decimaDiv").hide();
    $("#decimaPDiv").show();
    //   preencherRespostas();
    // getCalculo();
}); //FimProximoQuestao01

$("#btnDeseja2").click(function () {
    //Atribuindo Valor
    respostas[9] = $(this).val();
    //Mostrando e escondendo perguntas
    $("#decimaDiv").hide();
    $("#decimaPDiv").show();
    // preencherRespostas();
    // getCalculo();
}); //FimProximoQuestao01

//BOTÃO VOLTAR 10 
$("#Voltar10").click(function () {
    $("#decimaDiv").hide();
    $("#nonaDiv").show();
}); //FimProximoQuestao02

//Decima primeira questão
$("#Proximo11").click(function () {
    //Ajustando tabela dos resultados
    if (window.innerWidth == 300) {
        $("#vli_txt").css("width", "54%");
        $("#vli_valor").css("width", "47%");

    }


    const formBox = document.querySelector('#formContentQ11');

    const inputFieldN = document.querySelector('#valorNome');
    const inputFieldE = document.querySelector('#valorEmail');
    const inputFieldT = document.querySelector('#valorTelefone');

    const caixa = document.querySelector('#decimaPDiv');

    if (($("#valorNome").val().trim() != "") && ($("#valorEmail").val().trim() != "") && (($("#valorTelefone").val().trim() != "") && validarEmail() === true)) {

        //Atribuindo Valor
        respostas[10] = $("#valorNome").val();
        respostas[11] = $("#valorEmail").val();
        respostas[12] = $("#valorTelefone").val();
        
        $('.container').css('overflow', 'auto');
        //Mostrando e escondendo perguntas
        $("#decimaPDiv").hide();
        $('.wrapperQ01').css('padding', '5px');
        preencherRespostas();
        getCalculo();

    }
    else {
        if ($("#valorNome").val().trim() == "") {
            $("#valorNome").css("border-color", "#e21d2a");
            inputFail(formBox, inputFieldN, caixa);
        }

        else if ($("#valorEmail").val().trim() == "") {
            $("#valorEmail").css("border-color", "#e21d2a");
            inputFail(formBox, inputFieldE, caixa);
        }

        else {
            $("#valorTelefone").css("border-color", "#e21d2a");
            inputFail(formBox, inputFieldT, caixa);
        }

        $("#Proximo11").css("background-color", "#e21d2a");
        $("#Voltar11").css("background-color", "#e21d2a");
        $("#Voltar11").css("color", "#717171");
        $("#Voltar11").css("color", "white");
        $(".progress-bar").css("background-color", "#e21d2a");


    }



}); //FimProximoQuestao11

//BOTÃO VOLTAR 11 
$("#Voltar11").click(function () {
    $("#decimaPDiv").hide();
    $("#decimaDiv").show();
}); //FimProximoQuestao11

//Preencher dados no final
function preencherRespostas() {
    $("#resposta1").text(respostas[1]);
    $("#resposta2").text(respostas[2]);
    $("#resposta3").text(respostas[3]);
    $("#resposta4").text(respostas[4]);
    $("#resposta5").text(respostas[5]);
    $("#resposta6").text(respostas[6]);
    $("#resposta7").text(respostas[7]);
    $("#resposta8").text(respostas[8]);
}

//BOTÃO REINICIAR
$("#botaoNV").click(function () {
    location.reload(true);
}); //FimReiniciar 

//VALIDAÇÃO DO FORMS
function naLista(bairro) {
    for (let i = 0; i < suggestions.length; i++) {
        if (suggestions[i].label.indexOf(bairro) == 0) {
            return true
        }
    }
}

// Transition Times
const shakeTime = 100; // Shake Transition Time

// Transform To Create Shake Motion
function transform(x, y, formBox) {

    formBox.style.transform = `translate(${x}px, ${y}px)`;
}

function inputFail(formBox, inputField, caixa) {
    var aux = formBox;
    caixa.className = 'error';
    // Repeat Shake Motion -  Set i to number of shakes
    for (let i = 0; i < 6; i++) {
        //setTimeout(transform, shakeTime * i, ((i % 2) * 2 - 1) * 20, 0, aux);
        //setTimeout(transform, shakeTime * 6, 0, 0);

        inputField.focus();
    }

    function inputPass(caixa) {
        caixa.className = '';
    }
}

/*
MASCARAS DOS INPUTS, UTILIZANDO MASK E MASKMONEY
*/

//TELEFONE
var maskBehavior = function (val) {
    return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00009';
},
    options = {
        onKeyPress: function (val, e, field, options) {
            field.mask(maskBehavior.apply({}, arguments), options);
        }
    };

$('#valorTelefone').mask(maskBehavior, options);

//EMAIL
function validarEmail() {
    var email = document.getElementById('valorEmail');

    if (regexEmail(email.value)) {
        return true
        // Chama o Ajax e realiza ações com o email validado.
    } else {
        return false
        // mostra msgErro dizendo que o email do cliente não é valido.
    }

}
function regexEmail(email) {
    var regex = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
    return regex.test(email);
}

//NOME
$('#valorNome').bind('keyup blur', function () {
    var node = $(this);
    node.val(node.val().replace(/[^a-zA-Z\u00C0-\u00FF ]/g, ''));
}
);

//CAMPOS DE VALORES
$("#valorCondominio").maskMoney({
    prefix: 'R$ ',
    defaultZero: false,
    allowZero: true,
    decimal: ",",
    thousands: "."
});
$("#valorIPTU").maskMoney({
    prefix: 'R$ ',
    defaultZero: false,
    allowZero: true,
    decimal: ",",
    thousands: "."
});

$("#inputesperado").maskMoney({
    prefix: 'R$ ',
    defaultZero: false,
    allowZero: false,
    decimal: ",",
    thousands: "."
});

//POST DO FORMS
function postRequest(qtd_registros, indice_dados, range_max, range_min, indice_localizacao, vlmetro, vlim, vlc) {


    //event.preventDefault();
    var data = {};


    //ATRIBUINDO PARA O VETOR 
    data.Q01 = respostas[0];
    data.Q02 = respostas[1];
    data.Q03 = respostas[2];
    data.Q04 = respostas[3];
    data.Q05 = respostas[4];
    data.Q06 = respostas[5];
    data.Q07 = respostas[6];
    data.Q08 = respostas[7];
    data.Q09 = respostas[8];
    data.Q10 = respostas[9].trimStart().trimEnd();
    data.fonte = window.location.href;
    data.qtd_registros = qtd_registros;
    data.indice_dados = indice_dados;
    data.range_max = range_max;
    data.range_min = range_min;
    data.indice_localizacao = indice_localizacao;
    data.nome_lead = respostas[10];
    data.email_lead = respostas[11];
    data.telefone_lead = respostas[12];
    data.vlmetro = vlmetro;
    data.vlim = vlim;
    data.vlc = vlc;
    data.coordenadas = "LAT: "+latitude + ", LONG: " + longitude;
    if (idEmpresa != null) {
        data.id_empresa = idEmpresa;
    }
    else {
        data.id_empresa = "1";
    }
    //TRANSFORMANDO EM UMA STRING
    var jsonforms = JSON.stringify(data);
    //POST COM OS DADOS
    $.ajax({
        beforeSend: function (xhrObj) {
         
            xhrObj.setRequestHeader("Authorization", "Bearer " + key);
        },
        url: '/Widget/postWidget',
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: jsonforms,
        processData: false,
        success: function (data, textStatus, jQxhr) {
            id_questionario = data;
           

        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });

}

function getCalculo() {
    //event.preventDefault();
    var data = {};
    //PEGANDO VALORES DO FORMULARIO
    var Q01 = respostas[0];
    var Q02 = respostas[1];



    //ATRIBUINDO PARA O VETOR
    if (Q01 == "aluguel") {
        data.p_operacao = "Alugar";
    }
    else {
        data.p_operacao = "Comprar";
    }
    data.p_tipo_imovel = Q02;

    //Split no Bairro     
    var split = respostas[2].split('-')


    data.p_bairro_label = split[0].trim();

    data.p_cidade_label = split[1].trim();

    data.p_estado_label = split[2].trim();

    data.p_area_aproximada = respostas[3];

    data.p_qtd_quartos = respostas[4];

    data.p_qtd_banheiros = respostas[5];

    data.p_qtd_vagas = respostas[6];

    data.p_valor_codominio = respostas[7].replace('R$ ', '').replaceAll('.', '').replaceAll(',', '.');

    data.p_valor_iptu = respostas[8].replace('R$ ', '').replaceAll('.', '').replaceAll(',', '.');


    //TRANSFORMANDO EM UMA STRING
    var jsonCalculo = JSON.stringify(data);


    
    //POST COM OS DADOS
    $.ajax({
        beforeSend: function (xhrObj) {
         
            xhrObj.setRequestHeader("Authorization", "Bearer " + key);
        },
        url: '/CalculoDataImob/Calculo',
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: jsonCalculo,
        processData: false,
        success: function (data, textStatus, jQxhr) {

            mostrarResultado(data);

        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });

}


function getToken() {

    var credentials = {};
    credentials.Username = "DataImob";
    credentials.Password = "yc9qGtT!mR06";

    //TRANSFORMANDO EM UMA STRING
    var myJsonString = JSON.stringify(credentials);

    //POST COM OS DADOS
    $.ajax({

        url: '/DataImob/Login',
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: myJsonString,
        processData: false,
        success: function (data, textStatus, jQxhr, response) {

            key = data.token.toString();

        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}

/*
 * Avaliacao do Resultado
 *
 */

$(function () {
    $(".valoresperado").hide();
    $(".txt_avaliacao").hide();
    $('#avaliacao_estrelas').barrating({
        theme: 'fontawesome-stars',
        onSelect: function (value, text, event) {
            if (typeof (event) !== 'undefined') {
                // rating was selected by a user

                 avaliacao = event.target.getAttribute("data-rating-value");
                if (avaliacao <= 3) {
                    $(".valoresperado").show();
                    $(".stars_rating").hide();
                   

                }
                else {
                    enviarResultado(avaliacao,0);
                    $(".txt_avaliacao").show();
                    $(".stars_rating").hide();
                    $(".valoresperado").hide();

                }
            } else {

                // rating was selected programmatically
                // by calling `set` method
            }
        }
    });

    $("#btn_Avaliacao").on("click", function () {
        enviarResultado(avaliacao, $("#inputesperado").val());
      
        
        $(".txt_avaliacao").show();
        $(".stars_rating").hide();
        $(".valoresperado").hide();
    });

});

function enviarResultado(avaliacao, valor) {
    var data = {};
 
    data.id_questionario= id_questionario;
    data.avaliacao = avaliacao;
    data.valor_esperado = valor;
    //TRANSFORMANDO EM UMA STRING
    var jsonAvaliacao = JSON.stringify(data);
    //POST COM OS DADOS
    $.ajax({
        beforeSend: function (xhrObj) {

            xhrObj.setRequestHeader("Authorization", "Bearer " + key);
        },
        url: '/Widget/avaliacao',
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: jsonAvaliacao,
        processData: false,
        success: function (data, textStatus, jQxhr) {
 

        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}