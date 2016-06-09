<template>

<div id="home" class="app scale2 app-hide">
    <button class=" button" style="position: absolute; margin: auto; top: 0px; bottom: 0px; left: 0px; right: 0px;" v-on:click="startClick">
        Start
    </button>
    <p style="color: #999999">{{message}}</p>
</div>

<div id="skateView" class="app scale2 app-hide">
    <button class="button" style="position: absolute; margin: auto; top: 30px; left: 0px; right: 0px;" v-on:click="goHomeClick">Home</button>
    <input name="userName" style="position: absolute; top: 80px; left: 50%; width: 400px; margin-left: -225px" />
    <div id="grid1Div" style="width:920px;height:320px;overflow:auto;background-color:#DEDEDE; top: 150px; left: 50%; margin-left: -460px; position:absolute"></div>
</div>

<div id="login"  class="app scale2 app-hide">
  <div class="app-center" style="width: 500px; height: 400px;" align="center">
      <h2>Login</h2>

      <button class=" button" v-on:click="loginStartClick()">Login</button>
  </div>
</div>

</template>

<script>
import LoginComponent from './Login.vue'

export default {
  data () {
    return {
      currentViewName: ''
    }
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
      },
      startClick:function() {
          this.showView("skateView");
      },
      goHomeClick:function() {
          this.showView("home");
      },
      loginStartClick:function() {
          this.showView("skateView");
      }
  }
}
</script>

<style>

</style>
