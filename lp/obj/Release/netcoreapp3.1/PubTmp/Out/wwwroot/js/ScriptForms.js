//Definir o que será feito quando ele carregar
$(document).ready(function () {
    //Escondendo os outros cards

  
    //QUESTÕES
    //$("#PrimeiraDiv").hide();
    $(".SegundaQuestao").hide();
    $(".SegundaQuestao").hide();
    $(".TerceiraQuestao").hide();
    $(".QuartaQuestao").hide();
    $(".QuintaQuestao").hide();
    $(".SextaQuestao").hide();
    $("#setimaDiv").hide();
    $("#oitavaDiv").hide();
    $("#nonaDiv").hide();
    //Resultado
    //Resultado
    $("#resultadoDiv").hide();
    $("#resultadoDiv2").hide();
    $("#resultadoDiv3").hide();
    $("#respostasDiv").hide();
 
 
    //Ajustando primeiro card
    $('.wrapperQ01').css('padding-top', '30px');

});

//VARIAVEIS GLOBAIS
let respostas = {};
//Titulos
let titulos =["Descubra o valor do seu aluguel",
    "Descubra o valor do seu imóvel",
    "Quanto vale meu aluguel?",
    "Quanto vale meu imóvel?"];



//SCRIPT QUESTÃO 01
$("#btnaluguel").click(function () {
    //Escondendo Titulos
    $("#Titulo").text(titulos[0]);
    //Atribuindo Valor
    respostas[0] = "aluguel";
    //Mostrando e escondendo perguntas
    $("#PrimeiraDiv").hide();
    $("#SegundoDiv").show();
    //Texto Do resultado no segundo card
    $("#txtResultado2").text("Valor do Aluguel:");
}); //FimProximoQuestao01

$("#btnimovel").click(function () {
    //Escondendo Titulos
    $("#Titulo").text(titulos[1]);
    //Atribuindo Valor
    respostas[0] = "imovel";
    //Mostrando e escondendo perguntas
    $("#PrimeiraDiv").hide();
    $("#SegundoDiv").show();
    //Texto Do resultado no segundo card
    $("#txtResultado2").text("Valor do Imóvel:");
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


  

    $("#PrimeiraDiv").show();

    $("#SegundoDiv").hide();

}); //FimProximoQuestao02



//SCRIPT QUESTÃO 03

$("#Proximo3").click(function () {



    const formBox = document.querySelector('#formContentQ03');

    const inputField = document.querySelector('#Endereco');

    const caixa = document.querySelector('#terceiraDiv');

    if ($("#Endereco").val().trim() != "") {
        $("#Endereco").css("border-color", "");
        $("#Proximo3").css("background-color", "#5E83C2");
        $("#Voltar3").css("background-color", "#FFFFFF");
        $(".progress-bar").css("background-color", "#87C6E6");
        $("#Voltar3").css("color", "#717171");
        respostas[2] = $("#Endereco").val();
        $("#terceiraDiv").hide();
        $("#quartaDiv").show();



    }
    else {
        $("#Endereco").css("border-color", "#e21d2a");
        $("#Proximo3").css("background-color", "#e21d2a");
        $("#Voltar3").css("background-color", "#e21d2a");
        $(".progress-bar").css("background-color", "#e21d2a");
        $("#Voltar3").css("color", "white");
        inputFail(formBox, inputField, caixa);
    }


}); //FimProximoQuestao03


//BOTÃO VOLTAR 3
$("#Voltar3").click(function () {

    $("#Endereco").css("border-color", "");
    $("#Proximo3").css("background-color", "#5E83C2");
    $("#Voltar3").css("background-color", "#FFFFFF");
    $(".progress-bar").css("background-color", "#87C6E6");
    $("#Voltar3").css("color", "#717171");
    $("#SegundoDiv").show();

    $("#terceiraDiv").hide();

}); //FimProximoQuestao03


//SCRIPT QUESTÃO 04

$("#Proximo4").click(function () {

    const formBox = document.querySelector('#formContentQ04');

    const inputField = document.querySelector('#areaAproximada');
    const caixa = document.querySelector('#quartaDiv');

    if ($("#areaAproximada").val().trim() != "") {

        $("#areaAproximada").css("border-color", "");
        $("#Proximo4").css("background-color", "#5E83C2");
        $("#Voltar4").css("background-color", "#FFFFFF");
        $(".progress-bar").css("background-color", "#87C6E6");
        $("#Voltar4").css("color", "#717171");

        respostas[3] = $("#areaAproximada").val();
        $("#quartaDiv").hide();
        $("#quintaDiv").show();

    }
    else {
        $("#areaAproximada").css("border-color", "#e21d2a");
        $("#Proximo4").css("background-color", "#e21d2a");
        $("#Voltar4").css("background-color", "#e21d2a");
        $("#Voltar4").css("color", "white");

        $(".progress-bar").css("background-color", "#e21d2a");

        inputFail(formBox, inputField, caixa);

    }
}); //FimProximoQuestao04


//BOTÃO VOLTAR 4
$("#Voltar4").click(function () {

    $("#areaAproximada").css("border-color", "");
    $("#Proximo4").css("background-color", "#5E83C2");
    $("#Voltar4").css("background-color", "#FFFFFF");
    $("#Voltar4").css("color", "#717171");
    $(".progress-bar").css("background-color", "#87C6E6");


    $("#terceiraDiv").show();

    $("#quartaDiv").hide();

}); //FimProximoQuestao04


//SCRIPT QUESTÃO 05

$("#Proximo5").click(function () {

    const formBox = document.querySelector('#formContentQ05');
    const inputField = $("input:radio[name ='quartos']:checked");
    const caixa = document.querySelector('#quintaDiv');

    if ($("input:radio[name ='quartos']:checked").val() != null) {
        $("input:radio[name ='quartos']:checked").css("border-color", "");
        $("#Proximo5").css("background-color", "#5E83C2");
        $("#Voltar5").css("background-color", "#FFFFFF");
        $("#Voltar5").css("color", "#717171");
        $(".progress-bar").css("background-color", "#87C6E6");

        respostas[4] = $("input:radio[name ='quartos']:checked").val();
        $("#quintaDiv").hide();
        $("#sextaDiv").show();
    }
    else {

        $("input:radio[name ='quartos']:checked").css("border-color", "#e21d2a");
        $("#Proximo5").css("background-color", "#e21d2a");
        $("#Voltar5").css("background-color", "#e21d2a");
        $("#Voltar5").css("color", "white");

        $(".progress-bar").css("background-color", "#e21d2a");
        inputFail(formBox, inputField, caixa);

    }

    // $("#sextaDiv").show();
}); //FimProximoQuestao05


//BOTÃO VOLTAR 5
$("#Voltar5").click(function () {
    $("input:radio[name ='quartos']:checked").css("border-color", "");
    $("#Proximo5").css("background-color", "#5E83C2");
    $("#Voltar5").css("background-color", "#FFFFFF");
    $("#Voltar5").css("color", "#717171");
    $(".progress-bar").css("background-color", "#87C6E6");

    $("#quintaDiv").hide();
    $("#quartaDiv").show();

}); //FimProximoQuestao05



//SCRIPT QUESTÃO 06

$("#Proximo6").click(function () {

    const formBox = document.querySelector('#formContentQ06');

    const inputField = $("input:radio[name ='banheiros']:checked");

    const caixa = document.querySelector('#sextaDiv');

    if ($("input:radio[name ='banheiros']:checked").val() != null) {

        $("input:radio[name ='banheiros']:checked").css("border-color", "");
        $("#Proximo6").css("background-color", "#5E83C2");
        $("#Voltar6").css("background-color", "#FFFFFF");
        $("#Voltar6").css("color", "#717171");
        $(".progress-bar").css("background-color", "#87C6E6");


        respostas[5] = $("input:radio[name ='banheiros']:checked").val();

        $("#sextaDiv").hide();
        $("#setimaDiv").show();
    }
    else {

        $("input:radio[name ='banheiros']:checked").css("border-color", "#e21d2a");
        $("#Proximo6").css("background-color", "#e21d2a");
        $("#Voltar6").css("background-color", "#e21d2a");
        $("#Voltar6").css("color", "white");

        $(".progress-bar").css("background-color", "#e21d2a");
        inputFail(formBox, inputField, caixa);

    }
    // $("#sextaDiv").show();
}); //FimProximoQuestao04


//BOTÃO VOLTAR 6
$("#Voltar6").click(function () {

    $("input:radio[name ='banheiros']:checked").css("border-color", "");
    $("#Proximo6").css("background-color", "#5E83C2");
    $("#Voltar6").css("background-color", "#FFFFFF");
    $("#Voltar6").css("color", "#717171");
    $(".progress-bar").css("background-color", "#87C6E6");

    $("#sextaDiv").hide();
    $("#quintaDiv").show();

}); //FimProximoQuestao06



//SCRIPT QUESTÃO 07

$("#Proximo7").click(function () {

    const formBox = document.querySelector('#formContentQ07');

    const inputField = $("input:radio[name ='garagem']:checked");

    const caixa = document.querySelector('#setimaDiv');

    if ($("input:radio[name ='garagem']:checked").val() != null) {

        $("input:radio[name ='garagem']:checked").css("border-color", "");
        $("#Proximo7").css("background-color", "#5E83C2");
        $("#Voltar7").css("background-color", "#FFFFFF");
        $("#Voltar7").css("color", "#717171");
        $(".progress-bar").css("background-color", "#87C6E6");

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
    // $("#sextaDiv").show();
}); //FimProximoQuestao07


//BOTÃO VOLTAR 7
$("#Voltar7").click(function () {

    $("input:radio[name ='garagem']:checked").css("border-color", "");
    $("#Proximo7").css("background-color", "#5E83C2");
    $("#Voltar7").css("background-color", "#FFFFFF");
    $("#Voltar7").css("color", "#717171");
    $(".progress-bar").css("background-color", "#87C6E6");


    $("#setimaDiv").hide();
    $("#sextaDiv").show();

}); //FimProximoQuestao07
//SCRIPT QUESTÃO 08

$("#Proximo8").click(function () {

    const formBox = document.querySelector('#formContentQ08');

    const inputField = document.querySelector('#valorCondominio');

    const caixa = document.querySelector('#oitavaDiv');

    if ($("#valorCondominio").val().trim() != "") {

        $("#valorCondominio").css("border-color", "");
        $("#Proximo8").css("background-color", "#5E83C2");
        $("#Voltar8").css("background-color", "#FFFFFF");
        $(".progress-bar").css("background-color", "#87C6E6");

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

    $("#valorCondominio").css("border-color", "");
    $("#Proximo8").css("background-color", "#5E83C2");
    $("#Voltar8").css("background-color", "#FFFFFF");
    $("#Voltar8").css("color", "#717171");
    $(".progress-bar").css("background-color", "#87C6E6");

    $("#setimaDiv").show();
    $("#oitavaDiv").hide();


}); //FimProximoQuestao08


//SCRIPT QUESTÃO 09

$("#Proximo9").click(function () {

    const formBox = document.querySelector('#formContentQ09');

    const inputField = document.querySelector('#valorIPTU');

    const caixa = document.querySelector('#nonaDiv');

    if ($("#valorIPTU").val().trim() != "") {

        $("#valorIPTU").css("border-color", "");
        $("#Proximo9").css("background-color", "#5E83C2");
        $("#Voltar9").css("background-color", "#FFFFFF");
        $(".progress-bar").css("background-color", "#87C6E6");


        respostas[8] = $("#valorIPTU").val();

        $("#nonaDiv").hide();

        //Mostrando os Resultados Finais
        $("#resultadoDiv").show();
        $("#resultadoDiv2").show();
        $("#resultadoDiv3").show();
        $('.wrapperQ01').css('padding', '5px');
        $("#respostasDiv").show();
        preencherRespostas();

        

        if (respostas[0] == "aluguel") {
            $("#Titulo").text(titulos[2]);
         
        }
        else {
            $("#Titulo").text(titulos[3]);
           
        }
        console.log(respostas)

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
    // $("#sextaDiv").show();
}); //FimProximoQuestao09


//BOTÃO VOLTAR 9
$("#Voltar9").click(function () {

    $("#valorIPTU").css("border-color", "");
    $("#Proximo9").css("background-color", "#5E83C2");
    $("#Voltar9").css("background-color", "#FFFFFF");
    $("#Voltar9").css("color", "#717171");
    $(".progress-bar").css("background-color", "#87C6E6");

    $("#oitavaDiv").show();
    $("#nonaDiv").hide();

}); //FimProximoQuestao09

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





//VALIDAÇÃO DO FORMS

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
        setTimeout(transform, shakeTime * i, ((i % 2) * 2 - 1) * 20, 0, aux);
        setTimeout(transform, shakeTime * 6, 0, 0);

        inputField.focus();

    }

    function inputPass(caixa) {

        caixa.className = '';

    }


}

