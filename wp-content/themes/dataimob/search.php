<?php
/*
Template Name: Search Page
*/
$estiloPagina = "index.css";
require_once('header.php');
?>

<!-- banner -->
<section class="banner-interno" style="background-image: linear-gradient(to bottom, rgba(4, 99, 158, 0), rgba(4, 99, 158, 0.75)), url(<?php bloginfo('template_url'); ?>/assets/images/banner-interno.png);">
  <div class="container">
    <div class="row d-flex align-items-center justify-content-start">
      <div class="col-6 banner-interno__conteudo">
        <h1>Todos os artigos</h1>
        <p class="lead">Confira os melhores conteúdos sobre o mercado imobiliário!</p>
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
      else : ?>

        <div class="col-12 lista__semresultado">
          <p>Desculpe, nenhum resultado foi encontrado</p>
          <p><a href="<?php $url = site_url();
                      echo $url; ?>"><i class="fas fa-chevron-left"></i> Voltar para a home</a></p>
        </div>

      <?php endif; ?>

      <div class="lista__grafismo-baixo"></div>
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