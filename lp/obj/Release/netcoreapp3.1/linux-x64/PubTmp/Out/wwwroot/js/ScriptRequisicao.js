
let key = "";


getToken();


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

$('#impTelefone').mask(maskBehavior, options);




//EMAIL
function validarEmail() {
    var email = document.getElementById('impEmail');

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
$('#impNome').bind('keyup blur', function () {
    var node = $(this);
    node.val(node.val().replace(/[^a-zA-Z\u00C0-\u00FF ]/g, ''));
}
);




//POST DO FORMS 
$("#FormsRequisicao").submit(function (event) {
        event.preventDefault();
        var datareq = {};
        //PEGANDO VALORES DO FORMULARIO
        var nome = document.getElementById('impNome').value;
        var email = document.getElementById('impEmail').value;
        var telefone = document.getElementById('impTelefone').value;
        var nomeEmpresa = document.getElementById('impNomeEmpresa').value;
        var siteEmpresa = document.getElementById('impSite').value;
        var estadoEmpresa = document.getElementById('impEstadoEmpresa').value;
        var cidadeEmpresa = document.getElementById('impCidadeEmpresa').value;
        var cupomDesconto = document.getElementById('impCupom').value;
     
    if ((cupomDesconto.toUpperCase() === "GROUP50") || cupomDesconto === "") {
        
        //ATRIBUINDO PARA O VETOR 
        datareq.nome = nome;
        datareq.email = email;
        datareq.telefone = telefone;
        datareq.nomeEmpresa = nomeEmpresa;
        datareq.siteEmpresa = siteEmpresa;
        datareq.cupomDesconto = cupomDesconto;
        datareq.estadoEmpresa = estadoEmpresa;
        datareq.cidadeEmpresa = cidadeEmpresa;
        //TRANSFORMANDO EM UMA STRING
        var myJsonString = JSON.stringify(datareq);
        
        //POST COM OS DADOS
        $.ajax({
            beforeSend: function (xhrObj) {

                xhrObj.setRequestHeader("Authorization", "Bearer " + key);
            },
            url: '/parceiroregistro/requisicao',
            dataType: 'json',
            type: 'post',
            contentType: 'application/json',
            data: myJsonString,
            processData: false,
            success: function (data, textStatus, jQxhr) {
                if (data == 0) {
                    
                    $("#modalErroRegistro").modal('show');

                }
                if (data == 1)  {
                    $("#modalRegistro").modal('show');
                }
            },
            error: function (jqXhr, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });
      
    }
    else {

        $("#helpCupom").text("Digite um cupom valido.");
        $("#helpCupom").css("color", "red");
        $("#helpCupom").removeClass("text-muted");
        return false;

    }
});


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

$(document).ready(function () {

    $("#impEstadoEmpresa").click(function () {
        $("#impEstadoEmpresa").css("color", "black");
    });
});