<?php

// FUNCOES DO TEMA
function dataimob_adiciona_recursos_tema()
{
  add_theme_support('title-tag');
  add_theme_support('custom-logo');
  add_theme_support('post-thumbnails');
  add_image_size('destaque_posts', 1000, 500, true);
  add_image_size('imagem_post', 1000, 500, true);
  add_image_size('lista_posts', 350, 275, true);
}
add_action('after_setup_theme', 'dataimob_adiciona_recursos_tema');

// LIMITE DE RESUMO
function wpdocs_custom_excerpt_length( $length ) {
  return 25;
}
add_filter( 'excerpt_length', 'wpdocs_custom_excerpt_length', 999 );

// INCLUI NAV WALKER
function register_navwalker()
{
  require_once get_template_directory() . '/class-wp-bootstrap-navwalker.php';
}
add_action('after_setup_theme', 'register_navwalker');

// REGISTRA MENU
function dataimob_registra_menu()
{
  register_nav_menus(array(
    'menu-principal' => __('Menu Principal', 'dataimob'),
    'menu-rodape' => __('Menu Rodapé', 'dataimob'),
  ));
}
add_action('after_setup_theme', 'dataimob_registra_menu');

// SCRIPTS
function dataimob_scripts()
{
  wp_enqueue_style('critital', get_template_directory_uri() . '/assets/css/critical.css', array(), '1.0', 'all');
  
  wp_deregister_script('jquery');
  // wp_enqueue_script('jquery', 'https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js', array(), '3.5.1', true);
  // wp_enqueue_script('popper', 'https://cdnjs.cloudflare.com/ajax/libs/popper.js/2.4.4/umd/popper.min.js', array('jquery-js'), '2.4.4', true);
  // wp_enqueue_script('bootstrap', 'https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.0/js/bootstrap.min.js', array('jquery-js', 'popper-js'), '4.5.0', true);
  // wp_enqueue_script('validate', 'https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.2/jquery.validate.min.js', array('jquery-js'), '1.19.2', true);
  // wp_enqueue_script('mask', 'https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.min.js', array('jquery-js'), '1.14.16', true);
  wp_enqueue_script('acoes', get_template_directory_uri() . '/assets/js/scripts.min.js', array(), '1.0', true);

  // wp_enqueue_script('requisicao', get_template_directory_uri() . '/assets/js/components/ScriptRequisicao.js', array('acoes-js'), '1.0', true);
  // wp_enqueue_script('contato', get_template_directory_uri() . '/assets/js/components/ScriptContato.js', array('acoes-js', 'requisicao-js'), '1.0', true);
}
add_action('wp_enqueue_scripts', 'dataimob_scripts');

// REGISTRA SIDEBAR
// register_sidebar(
//   array(
//     "name" => "Barra lateral",
//     "id" => "sidebar",
//     "before_widget" => "<div class='widget'>",
//     "after_widget" => "</div>",
//     "before_title" => "<h5>",
//     "after_title" => "</h5>",
//   )
// );