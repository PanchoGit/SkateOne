<template>
	<h2>Home</h2>
	<div class="app-center" style="width: 500px; height: 500px;" align="center">
	</div>
	<button class="button" style="position: absolute; margin: auto; bottom: 50px; left: 0px; right: 0px;" v-on:click="goSkateView">Skate</button>
</template>

<style>
</style>

<script>
module.exports = {
	data: function(){
		return {
			msg: 'home'
		}
	},
	ready: function(){
		console.log("Home.ready");
	},
	methods: {
		goSkateView: function () {
			this.$dispatch('menu', 'skateView')
		}
	}
}
</script>