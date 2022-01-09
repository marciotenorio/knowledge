import Vue from 'vue'
import App from './App.vue'
import computedPropertyMixin from '@/computedPropertyMixin'

Vue.config.productionTip = false

Vue.filter('countWordAndAppendResult', (value) => {
	return value.split(' ').map( (str) => {
		return `${str} (${str.length})`
	})
	.join(' ')
})

Vue.mixin(computedPropertyMixin)

new Vue({
	render: h => h(App),
}).$mount('#app')
