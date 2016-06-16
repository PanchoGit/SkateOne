<template>

  <h2>Login</h2>
  <div class="app-center" style="width: 500px; height: 400px;" align="center">
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
  </div>
  <button class="button" style="position: absolute; margin: auto; bottom: 50px; left: 0px; right: 0px;" v-on:click="goHomeView">Login</button>

</template>

<script>
export default {
  data () {
    return {
      currentViewName: 'login'
    }
  },
  ready: function () {
    console.log("LoginVue.ready")
  },
  methods: {
    goHomeView: function () {
      this.$dispatch('menu', 'home')
    }
  }
}
</script>

<style>

</style>
