'use strict';

var gulp = require('gulp'),
    $ = require('gulp-load-plugins')();

var del = require('del');
var webpack = require('webpack-stream');
var webpackDevServer = require("webpack-dev-server");
var webpackConfig = require("./webpack.config.js");

$.paths = {
        vuejs: 'app/**/*.js+*.vue',
        html: 'app/**/*.html',
        js: 'app/**/*.js',
        image: 'app/**/*.+(png|jpg|gif|svg)',
        css: 'app/**/*.css',
        out: 'dist',
        dist: 'dist/**/*',
        appWeb: '../SkateOne.Web',
        appWebDist: '../SkateOne.Web/dist'
    };

gulp.task('webpack', function () {
  return gulp.src($.paths.vuejs)
    .pipe(webpack(webpackConfig))
    .pipe(gulp.dest($.paths.out));
});

gulp.task('scripts', function(){
    return gulp.src($.paths.js)
        .pipe(gulp.dest($.paths.out));
});

gulp.task('html', function(){
    return gulp.src($.paths.html)
        .pipe(gulp.dest($.paths.out));
});

gulp.task('images', function(){
  return gulp.src($.paths.image)
      .pipe(gulp.dest($.paths.out))
});

gulp.task('css', function(){
  return gulp.src($.paths.css)
      .pipe(gulp.dest($.paths.out))
});

gulp.task('clean:dist', function() {
  return del.sync($.paths.out);
})

gulp.task('clean-web:dist', function() {
  return del.sync($.paths.appWebDist, {force:true});
})

gulp.task('move-web:dist', function() {
  return gulp.src($.paths.dist)
    .pipe(gulp.dest($.paths.appWebDist));
})

gulp.task('build', function (callback) {
  $.sequence('clean:dist', 
    ['webpack','scripts','html','images','css'], 
    'clean-web:dist',
    'move-web:dist',
    callback
  )
});
