<template>

<div id="home" class="app scale2 app-hide">
  <home-component></home-component>
</div>

<div id="skateView" class="app scale2 app-hide">
  <skate-component></skate-component>
</div>

<div id="login"  class="app scale2 app-hide">
  <login-component></login-component>
</div>

</template>

<script>
import LoginComponent from './components/Login.vue'
import HomeComponent from './components/Home.vue'
import SkateComponent from './components/Skate.vue'

export default {
  data () {
    return {
      currentViewName: ''
    }
  },
  components: {
    LoginComponent,
    HomeComponent,
    SkateComponent
  },
  ready: function () {
    this.showView('login');
  },
  methods: {
      showView: function (name) {
          this.hideView(this.currentViewName);

          $("#" + name).removeClass("app-hide").removeClass("scale2");
          var item = document.getElementById(name);
          item.style.opacity = "0";
          item.style.transform = "scale(2,2)";
          item.style.display = "";

          this.currentViewName = name;
          TweenLite.to(item, 1, { scale: 1, alpha: 1, ease: Expo.easeInOut });
      },
      hideView: function (name) {
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
    'menu': function (view) {
      this.showView(view);
    }
  }
}
</script>

<style></style>
