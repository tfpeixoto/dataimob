<?php
/* Template Name: Home */
$estiloPagina = "home.css";
require_once("header.php");
?>

<!-- banner -->
<section class="banner home">
  <div class="container">
    <div class="row justify-content-between">
      <div class="col-12 col-md-7">
        <div class="row mb-4">
          <span>Conheça nossa nova ferramenta</span>
          <h1>Calculadora do valor do imóvel</h1>
          <p class="lead">A nova ferramenta da DataImob permite descobrir o valor de venda e/ou de aluguel dos imóveis de todo o Brasil, ajudando as imobiliárias a disponibilizarem aos seus clientes uma avaliação rápida e fácil de se usar, gerando um lead a cada valor calculado!</p>
          <p class="lead">Realize a simulação ao lado e descubra o potencial da ferramenta!</p>
        </div>

        <div class="row mb-4">
          <div class="col-4">
            <i class="far fa-paper-plane"></i>
            <p>Fácil Integração</p>
          </div>

          <div class="col-4">
            <i class="far fa-chart-bar"></i>
            <p>Geração de Leads Qualificados</p>
          </div>

          <div class="col-4">
            <i class="far fa-thumbs-up"></i>
            <p>Cálculo Assertivo do Valor do Imóvel</p>
          </div>
        </div>

        <div class="row mb-4">
          <div class="col-12">
            <a href="#saberMais" class="btn btn-lg btn-primary">Conheça</a>
            <a href="#sejaNossoParceiro" class="btn btn-lg btn-secondary">Seja uma Imobiliária Parceira</a>
          </div>
        </div>
      </div>

      <div class="col-12 col-md-4 widget">
        <iframe src="https://app.dataimob.com.br/widget?id=1" frameborder="0"></iframe>
      </div>
    </div>
  </div>
</section>

<!-- saber mais -->
<section id="saberMais" class="saber-mais">
  <div class="container">
    <div class="row">
      <div class="col-11 saber-mais__titulo">
        <h2>Instale o widget em seu site e capture mais clientes</h2>
        <p class="lead">Conquiste potenciais clientes e gere leads automaticamente. <span class="font-weight-bold">Veja os benefícios:</span></p>
      </div>
    </div>

    <div class="row saber-mais__beneficios">
      <div class="col-11 col-md-8 saber-mais__item">
        <div class="saber-mais__icone">
          <i class="far fa-gem"></i>
        </div>

        <div class="saber-mais__texto">
          <h3>Gere Leads de graça</h3>
          <p>Nossa plataforma irá te enviar os primeiros 20 leads diários totalmente gratuitos. Caso ultrapasse esse limite, entre em <a class="btMenu" href="#contato">contato com a DataImob</a> que lhe apresentaremos um de nossos planos.</p>
        </div>
      </div>

      <div class="col-11 col-md-8 saber-mais__item">
        <div class="saber-mais__icone">
          <i class="far fa-star"></i>
        </div>

        <div class="saber-mais__texto">
          <h3>Índices precisos e atualizados</h3>
          <p>Mensalmente revisamos nosso indicadores e reprocessamos nossos dados,
            garantindo sempre uma maior confiabilidade no cálculo do valor do imóvel. Caso queira saber mais sobre a DataImob, <a class="btMenu" href="#sobreNos">clique aqui</a> e conheça sobre as nossas próximas ferramentas que serão disponibilizadas.</p>
        </div>
      </div>

      <div class="col-11 col-md-8 saber-mais__item">
        <div class="saber-mais__icone">
          <i class="far fa-flag"></i>
        </div>

        <div class="saber-mais__texto">
          <h3>Personalizável</h3>
          <p>Personalize nosso Widget com as cores da sua empresa.</p>
        </div>
      </div>

      <div class="col-11 col-md-8 saber-mais__item">
        <div class="saber-mais__icone">
          <i class="far fa-check-circle"></i>
        </div>

        <div class="saber-mais__texto">
          <h3>Fácil instalação</h3>
          <p>Nosso Widget é muito prático de instalar! <a class="btMenu" href="#sejaNossoParceiro">Cadastre</a> em nosso site e receba um email com o script e o código único para a inserção no seu portal.</p>
        </div>
      </div>
    </div>

    <div class="row">
      <div class="col-12 saber-mais__cta">
        <a href="#sejaNossoParceiro" class="btn btn-lg btn-secondary"><span class="font-weight-bold">Clique aqui</span> e seja uma imobiliária parceira</a>
      </div>
    </div>
</section>

<!-- seja parceiro -->
<section id="sejaNossoParceiro" class="seja-parceiro">
  <div class="container">
    <div class="row align-items-center">
      <div class="col-12 col-md-6 seja-parceiro__intro">
        <h2>Seja Nosso Parceiro</h2>
        <p class="lead">Instale o widget em seu site agora mesmo</p>
        <i class="far fa-handshake fa-9x "></i>
        <p class="lead">Preencha o formulário ao lado para receber as instruções de instalação em seu site.</p>
      </div>

      <div class="col-12 col-md-6 seja-parceiro__form">
        <form id="FormsRequisicao">
          <div class="form-group">
            <label for="impNome" class="sr-only">Nome</label>
            <input type="text" class="form-control" id="impNome" aria-describedby="helpNome" placeholder="Digite seu nome completo" required>
          </div>

          <div class="form-group">
            <label for="impEmail" class="sr-only">E-mail</label>
            <input type="email" class="form-control" id="impEmail" aria-describedby="helpEmail" placeholder="contato@email.com" required>
          </div>

          <div class="form-group">
            <label for="impTelefone" class="sr-only">Telefone</label>
            <input type="text" class="form-control" id="impTelefone" aria-describedby="helpTelefone" placeholder="(00) 00000-0000" required>
          </div>

          <div class="form-group">
            <label for="impNomeEmpresa" class="sr-only">Telefone</label>
            <input type="text" class="form-control" id="impNomeEmpresa" aria-describedby="helpNomeEmpresa" placeholder="Nome da Empresa" required>
          </div>

          <div class="form-group">
            <input type="text" class="form-control" id="impSite" aria-describedby="helpSite" placeholder="Site da Empresa" required>
          </div>

          <div class="form-group">
            <input type="text" class="form-control" id="impCidadeEmpresa" aria-describedby="helpCidadeEmpresa" placeholder="Cidade" required>
          </div>

          <div class="form-group">
            <select name="select" class="form-control" id="impEstadoEmpresa" aria-describedby="helpEstadoEmpresa" placeholder="Estado da Empresa" required>
              <option value="" disabled selected>Escolha um estado</option>
              <option value="AC">Acre</option>
              <option value="AL">Alagoas</option>
              <option value="AP">Amapá</option>
              <option value="AM">Amazonas</option>
              <option value="BA">Bahia</option>
              <option value="CE">Ceará</option>
              <option value="DF">Distrito Federal</option>
              <option value="ES">Espírito Santo</option>
              <option value="GO">Goiás</option>
              <option value="MA">Maranhão</option>
              <option value="MT">Mato Grosso</option>
              <option value="MS">Mato Grosso do Sul</option>
              <option value="MG">Minas Gerais</option>
              <option value="PA">Pará</option>
              <option value="PB">Paraíba</option>
              <option value="PR">Paraná</option>
              <option value="PE">Pernambuco</option>
              <option value="PI">Piauí</option>
              <option value="RJ">Rio de Janeiro</option>
              <option value="RN">Rio Grande do Norte</option>
              <option value="RS">Rio Grande do Sul</option>
              <option value="RO">Rondônia</option>
              <option value="RR">Roraima</option>
              <option value="SC">Santa Catarina</option>
              <option value="SP">São Paulo</option>
              <option value="SE">Sergipe</option>
              <option value="TO">Tocantins</option>
            </select>
          </div>

          <div class="form-group">
            <input type="text" class="form-control" id="impCupom" aria-describedby="helpSite" placeholder="Cupom promocional">
            <span id="helpCupom"></span>
          </div>

          <div class="form-check">
            <input class="form-check-input" type="checkbox" value="" id="impTermo" required>
            <label class="form-check-label" for="impTermo">
              Eu li e concordo com os <a data-toggle="modal" data-target="#modalTermo" id="linktermoaceite" href="#modalTermo" class="tu"> termos de utilização.</a>
            </label>
          </div>

          <div id="r-captcha_parceiro" class="d-flex justify-content-center g-recaptcha" style="margin: 10px" data-sitekey="6LfIhNMaAAAAAAq4ZGLsDI1Nz1vh3bPXGVkLLpaG"></div>

          <button type="submit" class="btn btn-primary" id="Proximo11">Enviar</button>
        </form>
      </div>
    </div>
  </div>
</section>

<!-- sobre nos -->
<section id="sobreNos" class="sobre-nos">
  <div class="container">
    <div class="row">
      <div class="col-12 sobre-nos__titulo">
        <h2>Sobre Nós</h2>
      </div>
    </div>

    <div class="row">
      <div class="col-12 col-md-6 sobre-nos__item">
        <i class="far fa-user-circle"></i>
        <h3>Quem Somos</h3>
        <p>A DataImob é uma empresa de inteligência que desenvolve indicadores estratégicos para o mercado imobiliário.</p>
      </div>

      <div class="col-12 col-md-6 sobre-nos__item">
        <i class="far fa-edit"></i>
        <h3>Nosso Objetivo</h3>
        <p>Ser uma empresa referência no mercado de indicadores imobiliários, para isso contamos com muita inovação e tecnologia.</p>
      </div>

      <div class="col-12 col-md-6 sobre-nos__item">
        <i class="far fa-object-group"></i>
        <h3>O que Fazemos</h3>
        <p>Criamos ferramentas inteligentes que auxiliam na tomada de decisão, seja para comprar, vender, alugar ou construir um imóvel.</p>
      </div>

      <div class="col-12 col-md-6 sobre-nos__item">
        <i class="far fa-clipboard"></i>
        <h3>Como Fazemos</h3>
        <p>Cruzamos dados de diferentes fontes para ter sempre o melhor indicador financeiro sobre o mercado imobiliário, possibilitando oferecer informações precisas de acordo com as características de cada imóvel e sua localização.
        </p>
      </div>

      <div class="col-12 col-md-6 sobre-nos__item">
        <i class="far fa-compass"></i>
        <h3>O que Buscamos</h3>
        <p>Desenvolver parcerias estratégicas visando aprimorar nossa base de dados e criar soluções pensando na inovação do mercado imobiliário.</p>
      </div>

      <div class="col-12 col-md-6 sobre-nos__item">
        <i class="far fa-sun"></i>
        <h3>O que Ainda Iremos Fazer</h3>
        <p>Em breve teremos novidades e iremos contar!</p>
      </div>

      <div class="col-12 text-center my-4">
        <a href="#sejaNossoParceiro" class="btn btn-lg btn-primary"><span class="font-weight-bold">Clique aqui</span> e seja uma imobiliária parceira</a>
      </div>
    </div>
  </div>
</section>

<!-- contato -->
<section id="contato" class="contato">
  <div class="container">
    <div class="row justify-content-center">
      <div class="col-12 col-md-6 contato__titulo">
        <h2>Fale com a DataImob</h2>
        <span class="lead">Preencha o formulário abaixo e logo entraremos em contato.</span>
      </div>
    </div>

    <div class="row justify-content-center">
      <div class="col-12 col-md-6 contato__form">
        <form id="FormsContato">
          <div class="form-group">
            <input required type="text" class="form-control" id="impNome2" placeholder="Nome Completo">
          </div>

          <div class="form-group">
            <input required type="email" class="form-control" id="impEmail2" placeholder="E-mail">
          </div>

          <div class="form-group">
            <input required type="text" class="form-control" id="impAssunto2" placeholder="Assunto">
          </div>

          <div class="form-group">
            <textarea required class="form-control" id="exampleFormControlTextarea12" rows="3" placeholder="Mensagem"></textarea>
          </div>

          <div id="r-captcha_contato" class="d-flex justify-content-center g-recaptcha" style="margin: 10px" data-sitekey="6LfIhNMaAAAAAAq4ZGLsDI1Nz1vh3bPXGVkLLpaG"></div>

          <button type="submit" class="btn btn-primary">Enviar contato</button>
        </form>
      </div>
    </div>

    <div class="row">
      <div class="col-12 contato__email">
        <p>Se preferir, mande-nos um e-mail.<br /> <span class="text-primary">contato@dataimob.com.br</span></p>
      </div>
    </div>
  </div>
</section>

<?php
require_once('template-parts/modal-contato.php');
require_once('template-parts/modal-cookie.php');
require_once('template-parts/modal-registro-erro.php');
require_once('template-parts/modal-erro-captcha.php');
require_once('template-parts/modal-registro.php');
require_once('template-parts/modal-termo.php');

require_once('footer.php');
?>