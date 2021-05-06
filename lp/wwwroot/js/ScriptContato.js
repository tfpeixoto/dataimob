
//SCRIPT DO NAV LINK
var disbleRoll = false;
$(function () {
  function changeSelect(dataHash) {
    if (!dataHash) {
      dataHash = '#';
    }
    $('.nav-link').each(function () {
      if ($(this).hasClass('text-select')) {
        $(this).removeClass('text-select');
      }
      if ($(this).attr('a[href]').split('#')[1] == dataHash || $(this).attr('a[href]') == dataHash) {
        $(this).addClass('text-select');
      }
    });
  }

  $('.btMenu').click(function (e) {
    e.stopPropagation();
    disbleRoll = true;

    var dataHash = $(this).attr('a[href]');
    changeSelect(dataHash);
    if (!dataHash || dataHash == '#') {
      dataHash = '#banner';
    }

    $('body').animate({
      scrollTop: eval($(dataHash).offset().top)
    }, 1000, function () {
      disbleRoll = false;
    });
  });

  $(window).scroll(function (e) {
    $('section').each(function () {
      if ($(this).offset().top < window.pageYOffset + 20 && $(this).offset().top + $(this).height() > window.pageYOffset + 20 && disbleRoll == false) {
        var dataHash = $(this).attr('id');
        if (dataHash == 'banner') {
          dataHash = '#';
        }

        changeSelect(dataHash);
        window.location.hash = dataHash;
      }
    });
  });
});

$(document).ready(function () {
  //MODAIS
  //COOKIE
  $('.cc-link').click(function (e) {
    $("#modalCookies").modal('show');
  });

  $('#btnFecharCK').click(function (e) {
    $("#modalCookies").modal('hide');
  });

  $('#btnFecharCKHD').click(function (e) {
    $("#modalCookies").modal('hide');
  });

  //Contato
  $('#btnFecharCTT').click(function (e) {
    $("#modalContato").modal('hide');
    document.getElementById('impNome2').value = "";
    document.getElementById('impEmail2').value = "";
    document.getElementById('impAssunto2').value = "";
    document.getElementById('exampleFormControlTextarea12').value = "";

  });

  $('#btnFecharHCTT').click(function (e) {
    $("#modalContato").modal('hide');
    document.getElementById('impNome2').value = "";
    document.getElementById('impEmail2').value = "";
    document.getElementById('impAssunto2').value = "";
    document.getElementById('exampleFormControlTextarea12').value = "";

  });

  //Erro Registro
  $('#btnFecharHER').click(function (e) {
    $("#modalErroRegistro").modal('hide');


  });

  $('#btnFecharER').click(function (e) {
    $("#modalErroRegistro").modal('hide');


  });

  //Registro
  $('#btnFecharRE').click(function (e) {
    $("#modalRegistro").modal('hide');
    document.getElementById('impNome').value = "";
    document.getElementById('impEmail').value = "";
    document.getElementById('impTelefone').value = "";
    document.getElementById('impNomeEmpresa').value = "";
    document.getElementById('impSite').value = "";
    document.getElementById('impCupom').value = "";
    document.getElementById('impEstadoEmpresa').value = "";
    document.getElementById('impCidadeEmpresa').value = "";
    $("#impEstadoEmpresa").css("color", "#6C757D");
    $('#impTermo').prop('checked', false);

  });

  $('#btnFecharHRE').click(function (e) {
    $("#modalRegistro").modal('hide');
    document.getElementById('impNome').value = "";
    document.getElementById('impEmail').value = "";
    document.getElementById('impTelefone').value = "";
    document.getElementById('impNomeEmpresa').value = "";
    document.getElementById('impSite').value = "";
    document.getElementById('impCupom').value = "";
    document.getElementById('impEstadoEmpresa').value = "";
    document.getElementById('impCidadeEmpresa').value = "";
    $("#impEstadoEmpresa").css("color", "#6C757D");
    $('#impTermo').prop('checked', false);

  });
});

$(window).on('load', function () {
  $('.navbar-nav a ').click(function () {
    $('.navbar-nav a').removeClass('text-select');
    $(this).addClass('text-select');
  });
});

/*
VALIDAÇÕES DO FORMULARIO
*/

//EMAIL
function validarEmail() {
  var email = document.getElementById('impEmail2');

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
$('#impNome2').bind('keyup blur', function () {
  var node = $(this);
  node.val(node.val().replace(/[^a-zA-Z\u00C0-\u00FF ]/g, ''));
}
);


//POST DO FORMS 
$("#FormsContato").submit(function (event) {
  event.preventDefault();
  $("#modalContato").modal('show');
  //event.preventDefault();
  var dataContato = {};
  //PEGANDO VALORES DO FORMULARIO
  var nome = document.getElementById('impNome2').value;
  var email = document.getElementById('impEmail2').value;
  var assunto = document.getElementById('impAssunto2').value;
  var mensagem = document.getElementById('exampleFormControlTextarea12').value;

  //ATRIBUINDO PARA O VETOR 
  dataContato.nome = nome;
  dataContato.email = email;
  dataContato.assunto = assunto;
  dataContato.mensagem = mensagem;
  //TRANSFORMANDO EM UMA STRING
  var JsonContato = JSON.stringify(dataContato);

  //POST COM OS DADOS
  $.ajax({
    beforeSend: function (xhrObj) {

      xhrObj.setRequestHeader("Authorization", "Bearer " + key);
    },
    url: '/contato/contatoDataImob',
    dataType: 'json',
    type: 'post',
    contentType: 'application/json',
    data: JsonContato,
    processData: false,
    success: function (data, textStatus, jQxhr) {

    },
    error: function (jqXhr, textStatus, errorThrown) {
      console.log(errorThrown);
    }
  });



});

