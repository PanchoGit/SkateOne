<template>

<div id="login" class="app">
  <div class="app-center" style="width: 500px; height: 400px;" align="center">
      <h2>Login</h2>
      <form>
        <fieldset>
          <label>Username</label>
          <input name="username" style="width: 200px" />
        </fieldset>
        <fieldset>
          <label>Password</label>
          <input name="password" style="width: 200px" type="password" />
        </fieldset>
      </form>
      <button class=" button" v-on:click="loginStartClick()">Login</button>
  </div>
</div>

</template>

<script>
export default {
  data () {
    return {
      currentViewName: 'login'
    }
  }
}
</script>

<style>

</style>
