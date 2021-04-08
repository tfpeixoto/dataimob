<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <link rel="shortcut icon" href="<?= get_template_directory_uri() . '/assets/images/favicon.png' ?>" type="image/x-icon">

  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:400,500,700,900&display=swap" as="style" media="print" onload="this.media='all'; this.onload=null;" crossorigin>
  <?php wp_head(); ?>
  <link rel="stylesheet" href="<?= get_template_directory_uri() . '/assets/css/' . $estiloPagina ?>" as="style" media="print" onload="this.media='all'; this.onload=null;" crossorigin>
</head>

<body <?php body_class(); ?>>

  <header>
    <nav class="navbar navbar-expand-lg navbar-light">
      <div class="container">
        <!-- <a class="navbar-brand" href="#">DataImob</a> -->
        <?php the_custom_logo(); ?>

        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Alterna navegação">
          <span class="navbar-toggler-icon"></span>
        </button>

        <?php
        wp_nav_menu(array(
          'theme_location'  => 'menu-principal',
          'depth'           => 2,
          'container'       => 'div',
          'container_class' => 'collapse navbar-collapse',
          'container_id'    => 'navbarSupportedContent',
          'menu_class'      => 'navbar-nav',
          'fallback_cb'     => 'WP_Bootstrap_Navwalker::fallback',
          'walker'          => new WP_Bootstrap_Navwalker(),
        ));
        ?>
      </div>
    </nav>
  </header>