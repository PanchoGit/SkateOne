<template>
	<h2>Skate View</h2>
	<div class="app-center" style="width: 800px; height: 330px">
		<div id="grid1Div" style="width:600px;height:320px;overflow:auto;background-color:#DEDEDE; left: 50%; margin-left: -300px; position:absolute"></div>
	</div>
	<button class="button" style="position: absolute; margin: auto; bottom: 50px; left: 0px; right: 0px;" v-on:click="goHomeView">Home</button>
</template>

<style>
</style>

<script>
import service from '../services/skaterService'
import config from '../configuration/appConfig'

module.exports = {
	data: function(){
		return {
			skaters: []
		}
	},
	ready: function(){
		console.log("Skate.ready");
		this.getSkaters();
	},
	methods: {
		goHomeView: function () {
			this.$dispatch(config.event.menu, config.view.home)
		},
		getSkaters: function(){
			var self = this;
			service.getAll(this, (response) => {
					self.skaters = response.data;
					self.buildSkaterGrid();
				}, (response) => {
			});
		},
		buildSkaterGrid(){
			var data = [];
			for (var i = 0; i < this.skaters.length; i++) {
				var item = this.skaters[i];
				data.push([
					{'data': item.Id,'style':"font-weight:bold;"},
					{'data': item.Name },
					{'data': item.Brand },
					{'data': item.Stance }
				]);
			};

			var nGrid1;
			var table = {
			cols:[
				{title:"Id", 	width: "75", type:'number'},
				{title:"Name", 	width: "200", type:'string'},
				{title:"Brand", width: "150", type:'string'},
				{title:"Stance",width: "150", type:'string'}
				],
				rows: data
			};

			nGrid1 = new Ness.Grid({
				container : "grid1Div",
				dataTable : table
			});
			nGrid1.display();
		}
	}
}
</script>