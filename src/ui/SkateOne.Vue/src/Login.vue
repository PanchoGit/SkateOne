<template>

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
