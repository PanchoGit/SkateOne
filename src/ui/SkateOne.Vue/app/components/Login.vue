<template>

  <h2>Login</h2>
  <div class="app-center" style="width: 500px; height: 150px;" align="center">
    <form v-on:submit.prevent="login" class="form-horizontal">
      <div class="form-group">
        <label class="col-sm-2 control-label" for="username">Username</label>
        <div class="col-sm-10 input-group">
          <span class="input-addon">@</span>
          <input type="text" class="input-with-addon" id="username" name="username" style="width: 300px" v-model="loginUser.email" />
        </div>
      </div>
      <div class="form-group">
        <label class="col-sm-2 control-label" for="password">Password</label>
        <div class="col-sm-10 input-group">
          <span class="input-addon">*</span>
          <input class="input-with-addon" id="password" name="password" style="width: 300px" type="password" v-model="loginUser.password" />
        </div>
      </div>
      <div class="form-group">
        <button type="submit" name="" class="button">Login</button>
      </div>
    </form>

<alert
  :show.sync="showValidateAlert"
  :duration="3000"
  type="danger"
  width="400px"
  placement="top"
  dismissable>
  <span class="icon-info-circled alert-icon-float-left"></span>
  <ul class="errors">
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
      showValidateAlert: false,
      currentViewName: 'login'
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
