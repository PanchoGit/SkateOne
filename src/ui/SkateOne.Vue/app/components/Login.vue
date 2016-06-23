<template>

<div class="app-center" style="width: 500px; height: 350px;" align="center">
  <h2>Login</h2><br>
  <form v-on:submit.prevent="login">
    <fieldset>
      <label>Username</label>
      <input name="username" style="width: 300px" v-model="loginUser.email" />
    </fieldset><br>
    <fieldset>
      <label>Password</label>
      <input name="password" style="width: 300px" type="password" v-model="loginUser.password" />
    </fieldset><br>
    <fieldset>
      <input type="submit" name="" class="button" value="Login">
    </fieldset>
  </form>

<alert
  :show.sync="showValidateAlert"
  :duration="3000"
  type="danger"
  width="400px"
  placement="top"
  dismissable>
  <span class="icon-info-circled alert-icon-float-left"></span>
  <ul>
    <li v-show="!validation.email">Please provide a valid email address.</li>
    <li v-show="!validation.password">Password cannot be empty.</li>
  </ul>
</alert>

</div>

<!--<button class="button" style="position: absolute; margin: auto; bottom: 50px; left: 0px; right: 0px;" v-on:click="login">Login</button>-->

</template>

<script>
import {alert as Alert} from 'vue-strap'
var emailRE = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/

export default {
  data () {
    return {
      loginUser: {
        email: '',
        password: ''
      },
      showValidateAlert: false
    }
  },
  components: {
    Alert
  },
  ready: function () {
    console.log("LoginVue.ready")
  },
  computed: {
    validation: function () {
      return {
        email: emailRE.test(this.loginUser.email),
        password: !!this.loginUser.password.trim()
      }
    },
    isValid: function () {
      var validation = this.validation;
      return Object.keys(validation).every(function (key) { return validation[key] });
    }
  },
  methods: {
    validate: function(){
      return true;
    },
    login: function(){
      if(this.isValid)
      {
        this.goHomeView();
        return;
      }
      this.showValidateAlert = true;
    },
    goHomeView: function () {
      this.$dispatch('menu', 'home')
    }
  }
}
</script>

<style>

</style>
