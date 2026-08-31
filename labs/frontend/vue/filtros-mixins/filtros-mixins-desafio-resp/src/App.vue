<template>
	<div id="app">
		<h1>Filtros & Mixins (Desafio)</h1>
		<!-- Exercício 1 -->
		<!-- Construir um filtro local que troca espaços por vírgula -->
		<h5 style="background: green">Espaço por virgula local</h5>
		<h5>{{ 'Meu nome é Márcio e eu moro em Parnamirim' | spacesToCommas }}</h5>
	
		<!-- Exercício 2 -->
		<!-- Filtro global que conta o tamanho de cada palavra e adiciona o 
			valor na string final -->
		<!-- "Pedro é legal" => "Pedro (5) é (1) legal (5)" -->
		<h5 style="background: green">Nome com tamanho da palavra Global</h5>
		<h5>{{ 'Meu nome é Márcio e eu moro em Parnamirim' | countWordAndAppendResult }}</h5>

		<!-- Exercício 3 -->
		<!-- Implementar os exercicios 1 e 2 com propriedade computada -->
		<h5 style="background: green">Espaço por virgula computada</h5>
		<h5>{{ spacesToCommasComputed }}</h5>
		<h5 style="background: green">Nome com tamanho da palavra computada</h5>
		<h5>{{ countWordAndAppendResultComputed }}</h5>

		<!-- Exercício 4 -->
		<!-- Compartilhe a propriedade computada via mixin -->

	</div>
</template>

<script>
export default {
	filters: {
		spacesToCommas(value){
			return value.replaceAll(' ', ',');
		}
	},
	computed: {
		spacesToCommasComputed() {
			return this.strPhrase.replaceAll(' ', ',');
		},
		countWordAndAppendResultComputed(){
			return this.strPhrase.split(' ').map( (str) => {
				return `${str} (${str.length})`
			})
			.join(' ')	
		}
	}
}
</script>

<style>
#app {
	font-family: 'Avenir', Helvetica, Arial, sans-serif;
	-webkit-font-smoothing: antialiased;
	-moz-osx-font-smoothing: grayscale;
	text-align: center;
	color: #2c3e50;
	margin-top: 60px;
	font-size: 2.5rem;
}
</style>
