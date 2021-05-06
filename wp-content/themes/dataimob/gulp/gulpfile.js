var
gulp = require('gulp');
browserSync = require('browser-sync');
sass = require('gulp-sass');
// imagemin = require('gulp-imagemin');
concat = require('gulp-concat');
rename = require('gulp-rename');
uglify = require('gulp-uglify-es').default;
purgecss = require('gulp-purgecss');
purgecssWordpress = require('purgecss-with-wordpress');

gulp.task('browser-sync', function () {
  var files = [
    '../**/*.php',
    '../assets/css/*.css',
    '../assets/js/*.js'
  ];

  browserSync.init(files, {
    proxy: "http://localhost/dataimob",
    notify: true,
    stream: true,
    port: 3000
  });
});

gulp.task('sass', function () {
  return gulp.src(['scss/**/*.scss'])
    .pipe(sass({ outputStyle: 'compressed' }).on('error', sass.logError)) // converter o Sass em CSS
    .pipe(gulp.dest('/css'));
});

gulp.task('purgecss', ['sass'], function () {
  return gulp.src([
    '/css/*.css',
  ])
    .pipe(purgecss({
      content: ['../**/*.php'],
      whitelist: ['fa-compass', 'fa-sun', 'fa-clipboard', 'fa-object-group', 'fa-edit', 'fa-user-circle', 'fa-clock', 'modal', 'btn-close', 'btn-close-white', 'fa-times'],
      whitelistPatterns: [/^far/, /^fas/, /^fab/, /modal/, /^btn/]
    }))
    .pipe(gulp.dest('../assets/css'))
});

/* Imagens */
// gulp.task('imagemin', function () {
//   return gulp.src('../assets/images/**/*')
//     .pipe(imagemin({
//       progressive: true,
//       svgoPlugins: [
//         { removeViewBox: false },
//         { cleanupIDs: false }
//       ]
//     }))
//     .pipe(gulp.dest('../assets/images'));
// });

gulp.task('js', function () {
  return gulp.src([
    'js/jquery-3.5.1.min.js',
    'js/popper-1.16.1.min.js',
    'js/bootstrap-4.5.0.min.js',
    'js/jquery.mask-1.14.16.min.js',
    // 'js/components/jquery.validate-1.19.2.min.js',
    'js/acoes.js',
  ])
    .pipe(concat('scripts.js'))
    .pipe(gulp.dest('js'))
    .pipe(rename('scripts.min.js'))
    .pipe(uglify())
    .pipe(gulp.dest('../assets/js'))
});

gulp.task('watch', function () {
  gulp.watch(['scss/**/*.scss'], ['sass', 'purgecss']);
  gulp.watch('js/**/*.js', ['js']);
  // gulp.watch('../assets/images/**/*', ['imagemin']);
});

gulp.task('default', ['sass', 'purgecss', 'js', 'watch', 'browser-sync'])