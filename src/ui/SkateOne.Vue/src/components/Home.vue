<style>
.homeComponent h2 {
	color: #558844;
}
</style>

<template>
	<div class="homeComponent">
		<h2>{{msg}}<h2>
	</div>
</template>

<script>
module.exports = {
	data: function(){
		return {
			msg: 'home'
		}
	}
}
</script>