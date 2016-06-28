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
  <div style="text-align:left">
    <div v-show="!validation.email">
      <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
      Please provide a valid email address.
    </div>
    <div v-show="!validation.password">
      <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
      Password cannot be empty.
    </div>
  </div>
</alert>

</div>

</template>

<script>

import {alert as Alert} from 'vue-strap'
import validators from '../helpers/validators'
import config from '../configuration/appConfig'

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
        email: validators.emailPattern.test(this.loginUser.email),
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
      this.$dispatch(config.event.menu, config.view.home)
    }
  }
}
</script>

<style>

</style>
