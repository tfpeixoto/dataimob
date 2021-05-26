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
});


//POST DO FORMS 
$("#FormsRequisicao").on('submit', function (event) {
  var response = grecaptcha.getResponse(captcha_parceiro);

  if (response.length == 0) {
    $('#modalErroCaptcha').modal('show')
    event.preventDefault()
    return false
  }
  event.preventDefault()

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
      url: 'https://app.dataimob.com.br/parceiroregistro/requisicao',
      dataType: 'json',
      type: 'post',
      contentType: 'application/json',
      data: myJsonString,
      processData: false,
      success: function (data, textStatus, jQxhr) {
        if (data == 0) {
          $("#modalErroRegistro").modal('show');
        }
        if (data == 1) {
          $("#modalRegistro").modal('show');
        }
      },
      error: function (jqXhr, textStatus, errorThrown) {
        console.log(errorThrown);
      }
    });
  } else {
    $("#helpCupom").text("Digite um cupom valido.");
    $("#helpCupom").css("color", "red");
    $("#helpCupom").removeClass("text-muted");
    return false;
  }
});

$("#btnFecharHRE").on('click', function () {
  $("#FormsRequisicao")[0].reset();
  grecaptcha.reset(captcha_parceiro);
})

$("#btnFecharHER").on('click', function () {
  $("#FormsRequisicao")[0].reset();
  grecaptcha.reset(captcha_parceiro);
})

$("#btnFecharER").on('click', function () {
  $("#FormsRequisicao")[0].reset();
  grecaptcha.reset(captcha_parceiro);
})

$("#btnFecharRE").on('click', function () {
  $("#FormsRequisicao")[0].reset();
  grecaptcha.reset(captcha_parceiro);
})


function getToken() {
  var credentials = {};
  credentials.Username = "DataImob";
  credentials.Password = "yc9qGtT!mR06";

  //TRANSFORMANDO EM UMA STRING
  var myJsonString = JSON.stringify(credentials);

  //POST COM OS DADOS
  $.ajax({
    url: 'https://app.dataimob.com.br/DataImob/Login',
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

$(document).on('ready', function () {
  $("#impEstadoEmpresa").on('click', function () {
    $("#impEstadoEmpresa").css("color", "black");
  });
});


//SCRIPT DO NAV LINK
// var disbleRoll = false;
// $(function () {
//   function changeSelect(dataHash) {
//     if (!dataHash) {
//       dataHash = '#';
//     }
//     $('.nav-link').each(function () {
//       if ($(this).hasClass('text-select')) {
//         $(this).removeClass('text-select');
//       }
//       if ($(this).attr('a[href]').split('#')[1] == dataHash || $(this).attr('a[href]') == dataHash) {
//         $(this).addClass('text-select');
//       }
//     });
//   }

//   $('.btMenu').on('click', function (e) {
//     e.stopPropagation();
//     disbleRoll = true;

//     var dataHash = $(this).attr('a[href]');
//     changeSelect(dataHash);
//     if (!dataHash || dataHash == '#') {
//       dataHash = '#banner';
//     }

//     $('body').animate({
//       scrollTop: eval($(dataHash).offset().top)
//     }, 1000, function () {
//       disbleRoll = false;
//     });
//   });

//   $(window).on('scroll', function (e) {
//     $('section').each(function () {
//       if ($(this).offset().top < window.pageYOffset + 20 && $(this).offset().top + $(this).height() > window.pageYOffset + 20 && disbleRoll == false) {
//         var dataHash = $(this).attr('id');
//         if (dataHash == 'banner') {
//           dataHash = '#';
//         }

//         changeSelect(dataHash);
//         window.location.hash = dataHash;
//       }
//     });
//   });
// });

$(document).on('ready', function () {
  //MODAIS
  //COOKIE
  $('.cc-link').on('click', function (e) {
    $("#modalCookies").modal('show');
  });

  $('#btnFecharCK').on('click', function (e) {
    $("#modalCookies").modal('hide');
  });

  $('#btnFecharCKHD').on('click', function (e) {
    $("#modalCookies").modal('hide');
  });

  //Contato
  $('#btnFecharCTT').on('click', function (e) {
    $("#modalContato").modal('hide');
    document.getElementById('impNome2').value = "";
    document.getElementById('impEmail2').value = "";
    document.getElementById('impAssunto2').value = "";
    document.getElementById('exampleFormControlTextarea12').value = "";
  });

  $('#btnFecharHCTT').on('click', function (e) {
    $("#modalContato").modal('hide');
    document.getElementById('impNome2').value = "";
    document.getElementById('impEmail2').value = "";
    document.getElementById('impAssunto2').value = "";
    document.getElementById('exampleFormControlTextarea12').value = "";
  });

  //Erro Registro
  $('#btnFecharHER').on('click', function (e) {
    $("#modalErroRegistro").modal('hide');
  });

  $('#btnFecharER').on('click', function (e) {
    $("#modalErroRegistro").modal('hide');
  });

  //Registro
  $('#btnFecharRE').on('click', function (e) {
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

  $('#btnFecharHRE').on('click', function (e) {
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
  $('.navbar-nav a ').on('click', function () {
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
});


//POST DO FORMS 
$("#FormsContato").on('submit', function (event) {
  var response = grecaptcha.getResponse(captcha_contato);

  if (response.length === 0) {
    $('#modalErroCaptcha').modal('show')
    event.preventDefault()
    return false
  }
  event.preventDefault()
  $('#modalContato').modal('show')

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
    url: 'https://app.dataimob.com.br/contato/contatoDataImob',
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

$("#btnFecharHCTT").on('click', function () {
  $("#FormsContato")[0].reset();
  grecaptcha.reset(captcha_contato);
})

$("#btnFecharCTT").on('click', function () {
  $("#FormsContato")[0].reset();
  grecaptcha.reset(captcha_contato);
})