<?php
$estiloPagina = "single.css";
require_once('header.php');
?>

<!-- conteudo post -->
<?php
if (have_posts()) : while (have_posts()) : the_post();
    $data_post = get_the_date();
    $link_autor = get_the_author_link();
?>

    <article class="post">
      <div class="container">
        <div class="row d-flex justify-content-center">
          <div class="col-12 col-md-10 post__header">
            <h1><?php the_title(); ?></h1>
            <p>
              <span class="post__header__data"><?= $data_post ?></span>
              <?= $link_autor ?>
              <!-- <a href="#" class="post__header__autor">por DataImob</a> -->
              <span class="post__header__tempo">6 minutos de leitura</span>
            </p>
          </div>

          <div class="col-12 post__imagem">
            <?php the_post_thumbnail('imagem_post'); ?>
          </div>
        </div>

        <div class="row post__conteudo">
          <div class="col-12 col-md-2 post__conteudo__social">
            <ul>
              <li><a href="#">Linkedin</a></li>
              <li><a href="#">Twitter</a></li>
              <li><a href="#">Facebook</a></li>
              <li><a href="#">Whatsapp</a></li>
              <li><a href="#">Email</a></li>
            </ul>
          </div>

          <div class="col-12 col-md-10 post__conteudo__texto">
            <?php the_content() ?>
          </div>
        </div>
      </div>
    </article>

<?php endwhile;
endif;
wp_reset_query();
?>

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

<!-- lista posts -->
<section class="lista">
  <div class="container">
    <div class="row">
      <div class="col-12 lista__titulo">
        <h2>Confira também</h2>
      </div>
    </div>

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

<?php
require_once('footer.php');
?>