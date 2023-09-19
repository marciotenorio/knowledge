new Vue({
	el: '#desafio',
	data: {
		changeClassTimeout: undefined,
		progressBarInterval: undefined,
		classesForAlternateEffect: {
			destaque: false,
			encolher: false,
			trueOrFalseClass: '',
		},
		userDefinedClass: '',
		userDefinedClass2: '',
		trueOrFalseClass: '',
		progressBarClass: '',
		styleLikeString: '',
		progressCount: 0
	},
	methods: {
		iniciarEfeito() {
			if(!this.changeClassTimeout){
				this.changeClassTimeout = setInterval(this.alternateClass, 1000);
			}
		},
		iniciarProgresso() {
			this.progressBarInterval = setInterval(this.generateProgressBarStyle, 500)
		},
		generateProgressBarStyle(){
			this.progressBarClass = `width: ${this.progressCount += 10}px` + ';' + 'background-color: red;'
		},
		alternateClass() {
			let actualValue = this.classesForAlternateEffect.destaque
			this.classesForAlternateEffect.destaque = !actualValue;
			this.classesForAlternateEffect.encolher = actualValue;
		}
	},
	watch: {
		progressCount(){
			if(this.progressCount >= 341){
				clearInterval(this.progressBarInterval)
			}
		}
	}
})
