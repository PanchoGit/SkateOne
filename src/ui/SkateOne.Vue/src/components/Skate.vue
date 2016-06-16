<template>
	<h2>Skate View</h2>
	<div class="app-center" style="width: 500px; height: 500px;" align="center">
		<div id="grid1Div" style="width:920px;height:320px;overflow:auto;background-color:#DEDEDE; top: 150px; left: 50%; margin-left: -460px; position:absolute"></div>
	</div>
	<button class="button" style="position: absolute; margin: auto; bottom: 50px; left: 0px; right: 0px;" v-on:click="goHomeView">Home</button>
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
		console.log("Skate.ready");
	},
	methods: {
		goHomeView: function () {
			this.$dispatch('menu', 'home')
		}
	}

}
</script>