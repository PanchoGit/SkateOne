import Vue from 'vue'
import App from './App.vue'

Vue.config.debug = true
Vue.config.devtools = true

new Vue({
  el: 'body',
  components: { App }
})
