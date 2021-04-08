<?php
/* Page Template: Home */
$estiloPagina = "home.css";
require_once("header.php");
?>

<!-- banner -->
<section class="banner">
  <div class="container">
    <div class="row">
      <div class="col-12">
        <?php
        $args = array(
          'posts_per_page' => '1'
        );

        $post_destaque = new WP_Query($args);

        if ($post_destaque->have_posts()) : while ($post_destaque->have_posts()) : $post_destaque->the_post();
            $data_post = get_the_date();
            $link_autor = get_the_author_link();
        ?>

            <div class="banner__destaque" style="background-image: linear-gradient(to bottom, rgba(4, 99, 158, 0), rgba(4, 99, 158, 0.75)), url(<?php the_post_thumbnail_url(); ?>)">
              <div class="banner__destaque__conteudo">
                <div class="titulo">
                  <p class="small"><?= $data_post ?> por <?= $link_autor ?></p>
                  <h1><a href="<?php the_permalink(); ?>"><?php the_title(); ?></a></h1>
                </div>

                <div class="resumo">
                  <?php the_excerpt(); ?>
                </div>
              </div>
            </div>

        <?php endwhile;
        endif;
        wp_reset_query();
        ?>
      </div>
    </div>
  </div>
</section>

<!-- pesquisa -->
<section class="busca">
  <div class="container">
    <div class="row d-flex justify-content-center">
      <div class="col-12 col-md-10 busca__box">
        <div class="busca__box__titulo">
          <p>Encontre artigos</p>
        </div>

        <div class="busca__box__form">
          <form role="search" method="get" id="searchform" class="searchform form-inline" action="<?php echo esc_url(home_url('/')); ?>">
            <label class="screen-reader-text" for="s"><?php _x('Search for:', 'label'); ?></label>
            <input type="text" class="form-control" value="<?php echo get_search_query(); ?>" name="s" id="s" />
            <button type="submit" id="searchsubmit"><i class="fas fa-search"></i></button>
          </form>
        </div>
      </div>
    </div>
  </div>
</section>

<!-- lista posts -->
<section class="lista">
  <div class="container">
    <div class="row">
      <div class="lista__grafismo-topo"></div>

      <?php
      $args = array(
        'posts_per_page' => '6'
      );

      $posts_home = new WP_Query($args);

      if ($posts_home->have_posts()) : while ($posts_home->have_posts()) : $posts_home->the_post();
          $data_post = get_the_date();
          $link_autor = get_the_author_link();
      ?>

          <div class="col-12 col-md-4">
            <article class="card lista__post">
              <p class="data"><?= $data_post ?></p>

              <div class="lista__post__imagem">
                <a href="<?php the_permalink(); ?>" title="<?php the_title(); ?>">
                  <?php the_post_thumbnail('lista_posts'); ?>
                </a>
              </div>

              <div class="lista__post__conteudo">
                <h2><a href="<?php the_permalink(); ?>" title="<?php the_title(); ?>"><?php the_title(); ?></a></h2>
                <?php the_excerpt(); ?>
                <p class="small">por <?= $link_autor ?></p>
              </div>
            </article>
          </div>

      <?php endwhile;
      endif;
      wp_reset_query();
      ?>

      <div class="lista__grafismo-baixo"></div>
    </div>

    <div class="row lista__vermais">
      <a href="<?php $url = bloginfo('url');
                echo $url ?>/blog">Ver todos os artigos</a>
    </div>
  </div>
</section>

<!-- sobre -->
<section class="sobre">
  <div class="container">
    <div class="row d-flex justify-content-center">
      <div class="col-12 col-md-2 sobre__marca">
        <img src="<?php bloginfo('template_url'); ?>/assets/images/dataimob-marcaneg.svg" width="160" height="91" class="img-fluid" alt="Marca DataImob" title="Marca DataImob" />
      </div>

      <div class="col-12 col-md-6 sobre__conteudo">
        <p>A DataImob é uma empresa de inteligência que desenvolve indicadores estratégicos para o mercado imobiliário. Nosso objetivo é empresa referência no mercado de indicadores imobiliários, para isso contamos com muita inovação e tecnologia.</p>
      </div>
    </div>
  </div>
</section>

<?php
require_once('footer.php');
?>