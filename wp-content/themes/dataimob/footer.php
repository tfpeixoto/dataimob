<!-- footer -->
<footer class="copy">
  <div class="container">
    <div class="row d-flex justify-content-center">
      <div class="col-12 col-md-3 copy__marca">
        <img src="<?php bloginfo('template_url'); ?>/assets/images/dataimob-marcahor.svg" width="175" height="37" alt="DataImob marca" title="DataImob marca" />
      </div>

      <div class="col-12 col-md-9 copy__conteudo">
        <p>© 2021 - Todos os Direitos Reservados - DataImob</p>
      </div>
    </div>
  </div>
</footer>

<?php wp_footer(); ?>
<link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/cookieconsent@3/build/cookieconsent.min.css">
<script src="https://cdn.jsdelivr.net/npm/cookieconsent@3/build/cookieconsent.min.js" data-cfasync="false"></script>
<script>
  window.cookieconsent.initialise({
    "palette": {
      "popup": {
        "background": "#2096df"
      },
      "button": {
        "background": "#79c0ec"
      }
    },
    "theme": "edgeless",
    "position": "bottom-right",
    "type": "opt-out",

    "content": {
      "message": "Este site usa cookies para melhorar a sua experiência de navegação. Você pode configurar o seu navegador para rejeitar estes cookies. Nesse caso, a navegação e os serviços deste site podem ser limitados. Se você não modificar as opções e continuar navegando, estará ciente acerca do uso de cookies neste site e aceitando as nossas Políticas de Cookies e de Privacidade. Para mais informações consulte:",
      "allow": "Aceitar",
      "dismiss": "Aceitar",
      "deny": "Recusar",
      "target": "",
      "href": "#",
      "link": "Política de cookies.",
      "policy": "Política de cookies"
    }
  });
</script>

</body>

</html>