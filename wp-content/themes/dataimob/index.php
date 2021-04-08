<?php
$estiloPagina = "index.css";
require_once('header.php');
?>

<!-- banner -->
<section class="banner-interno">
  <div class="container">
    <div class="row">
      <div class="col-12">
        <div class="banner__interno">
          <img src="#" alt="#" title="#" />

          <div class="banner__interno__conteudo">
            <h1>Todos os artigos</h1>
            <p class="lead">Confira os melhores conteúdos sobre o mercado imobiliário! <a href="#"> > </a></p>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

<!-- lista posts -->
<section class="lista">
  <div class="container">
    <div class="row">
      <?php
      if (have_posts()) : while (have_posts()) : the_post();
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