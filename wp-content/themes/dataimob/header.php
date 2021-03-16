<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <?php wp_head(); ?>
  <link rel="stylesheet" href="<?= get_template_directory_uri() . '/assets/css/' . $estiloPagina ?>" as="style" media="print" onload="this.media='all'; this.onload=null;" crossorigin>
  <link rel="stylesheet" href="<?= get_template_directory_uri(); ?>/assets/css/home.css">
</head>

<body <?php body_class(); ?>>

<h1><?php the_title(); ?></h1>