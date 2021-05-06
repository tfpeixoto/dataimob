/*Script do Chat */

document.onreadystatechange = function () {
    if (document.readyState == "interactive") {
        var head = document.head;
        var link = document.createElement("link");

        link.type = "text/css";
        link.rel = "stylesheet";

         //link.href = "https://localhost:44379/widget/css/widgetstyles.css?v00.8";
         link.href = "https://dataimob.com.br/widget/css/widgetstyles.css?v00.26";

        head.appendChild(link);
        if (document.getElementById('btn-Widget_DI') != null) {
            //BotaoAbrir
            document.getElementById('btn-Widget_DI').addEventListener('click', function () {
                abrirChat();
            });
        }
        if (document.getElementById('btn-Widget_DI') != null) {

            //BotaoFechar
            document.getElementById('btnFechar_DI').addEventListener('click', function () {
                fecharChat();
            });
        }
    }
}

//ABRIR E FECHAR O WIDGET
function abrirChat() {
    var chat = document.getElementById("widget_DI");
    var btnChat = document.getElementById("btn-Widget_DI");
    btnChat.style.display = "none";
    chat.style.display = "block";
}

function fecharChat() {
    var chat = document.getElementById("widget_DI");
    var btnChat = document.getElementById("btn-Widget_DI");
    chat.style.display = "none";
    btnChat.style.display = "block";
}





//Cria primeira Div
var WidgetSmall_DI = document.createElement('div');
WidgetSmall_DI.setAttribute("id", "WidgetSmall_DI");


//COLOCAR OUTRA DIV NA ROW PRINCIPAL A CHAT_ON
//Cria proxima Div
var Layout_DI = document.createElement('div');
Layout_DI.setAttribute("class", "Layout_DI Layout-open_DI Layout-expand_DI Layout-right_DI");
Layout_DI.setAttribute("id", "widget_DI");

//Atribui a Anterior 
WidgetSmall_DI.append(Layout_DI);

//Cria proxima Div
var DI_WidgetArea = document.createElement('div');
DI_WidgetArea.setAttribute("class", "DI_WidgetArea");
//Atribui a Anterior
Layout_DI.append(DI_WidgetArea);

//Cria Span(botão que fecha) Div
var close_icon_DI = document.createElement('span');
close_icon_DI.setAttribute("class", "close_icon_DI");
close_icon_DI.setAttribute("id", "btnFechar_DI");
//var texto = document.createTextNode("X");
//close_icon_DI.appendChild(texto);
close_icon_DI.innerHTML = '<span style="background: #333; color: #FFF; padding: 2.5px 8px; font-family: Tahoma; font-weight: bold; border-radius: 4px; position: absolute; right: 0px; top: 0px;">x</span>';
//Atribui a quinta
DI_WidgetArea.append(close_icon_DI);

//Cria i(botão que fecha) Div
var fa_window_close = document.createElement('i');
fa_window_close.setAttribute("aria-hidden", "true");

//Atribui a Anterior 
close_icon_DI.append(fa_window_close);




//Cria proxima Div
var iframeDiv = document.createElement('div');
iframeDiv.setAttribute("id", "iframeDiv_DI");
iframeDiv.setAttribute("class", "row1 justify-content-center align-content-start");
//Atribui a Anterior 
DI_WidgetArea.append(iframeDiv);

//Pega dados da cor do widget
var url = document.getElementById('DataImobScript').getAttribute('src');
var partes = url.split('?');
console.log(partes)
if (partes.length > 1) {
    var header = partes[3];
    var txt = partes[4];
}
//PEGA ID USADO NO WIDGET
var idUser = document.getElementById('DataImobScript').getAttribute('src').split('?')[1].split('=')[1].split('&')[0];
//Cria proxima Div
var iframe = document.createElement('iframe');
iframe.setAttribute("id", "iframeDiv_DI");
iframe.setAttribute("src", "https://dataimob.com.br/widget?id=" + idUser + "&" + header + "&" + txt);
//iframe.setAttribute("src", "https://localhost:44379/widget?id=" + idUser + "&header=" + header + "&txt=" + txt);

//Atribui a Anterior 
iframeDiv.append(iframe);

var cor = header.split('=');
var r = document.querySelector(':root');
r.style.setProperty('--cor-bg-header', cor[1].replace('%23', '#'));




if (document.getElementById('btn-Widget_DI') == null) {
    //Cria proxima Div
    var widget_on_DI = document.createElement('div');
    widget_on_DI.setAttribute("class", "widget-on_DI");
    widget_on_DI.setAttribute("id", "btn-Widget_DI");
    //Atribui a Anterior 
    WidgetSmall_DI.append(widget_on_DI);

    //Cria proxima Div
    var img = document.createElement('img');
    img.setAttribute("id", "img-BTN_DI");
    //Atribui a Anterior 
    widget_on_DI.append(img);


    //Cria proxima Div
    var txt_div_DI = document.createElement('div');
    txt_div_DI.setAttribute("class", "txt_div_DI");
    //Atribui a Anterior 
    widget_on_DI.append(txt_div_DI);

    //Cria proxima Div
    var txt_calc = document.createElement('div');
    var content = document.createTextNode("Calcular");
    txt_calc.setAttribute("id", "txt_calc");
    //Atribui a Anterior 
    txt_calc.appendChild(content);
    txt_div_DI.append(txt_calc);

    //Cria proxima Div
    var txt_valor = document.createElement('div');
    txt_valor.setAttribute("id", "txt_valor");
    var content = document.createTextNode("o valor do seu");
    //Atribui a Anterior 
    txt_valor.appendChild(content);
    txt_div_DI.append(txt_valor);

    //Cria proxima Div
    var txt_imovel = document.createElement('div');
    txt_imovel.setAttribute("id", "txt_imovel");
    var content = document.createTextNode("imóvel");
    //Atribui a Anterior 
    txt_imovel.appendChild(content);
    txt_div_DI.append(txt_imovel);
}

//document.insertBefore(divModal);
document.body.appendChild(WidgetSmall_DI);