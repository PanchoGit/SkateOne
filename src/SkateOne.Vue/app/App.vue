<template>

<div id="slideView1" class="app scale2 app-hide">
  <component :is="currentView1"></component>
</div>
<div id="slideView2" class="app scale2 app-hide">
  <component :is="currentView2"></component>
</div>

</template>

<script>

import loginView from './components/login.vue'
import homeView from './components/home.vue'
import skateView from './components/skate.vue'
import config from './configuration/appConfig'

export default {
  data () {
    return {
      currentView1: '',
      currentView2: '',
      isCurrentView1: true,
      currentViewName: ''
    }
  },
  components: {
    loginView,
    homeView,
    skateView
  },
  ready: function () {
    this.init();
  },
  methods: {
    init: function(){
      var self = this;
      page('/home', function(){
        self.showSlideView(config.view.home)
      })
      page('/skate', function(){
        self.showSlideView(config.view.skate)
      })
      page('/', function(){
        self.showSlideView(config.view.home)
      })
      page()
    },
    showSlideView: function(view) {
      if(this.isCurrentView1)
      {
        this.currentView1 = view;
        this.isCurrentView1 = false;
        this.showView('slideView1');
      } else {
        this.currentView2 = view;
        this.isCurrentView1 = true;
        this.showView('slideView2');
      }
    },
    showView: function(name) {
        this.hideView(this.currentViewName);

        $("#" + name).removeClass("app-hide").removeClass("scale2");
        var item = document.getElementById(name);
        item.style.opacity = "0";
        item.style.transform = "scale(2,2)";
        item.style.display = "";

        this.currentViewName = name;
        TweenLite.to(item, 1, { scale: 1, alpha: 1, ease: Expo.easeInOut });
    },
    hideView: function(name) {
      if(name === ''){
        return;
      }
      var item = document.getElementById(name);
      TweenLite.to(item, 1, {
        scale: 1.5, alpha: 0, ease: Expo.easeInOut, onComplete: function () {
          item.style.display = "none";
        }
      });
    }
  },
  events: {
    'menu': function(view) {
      this.showSlideView(view);
    }
  }
}
</script>

<style></style>
