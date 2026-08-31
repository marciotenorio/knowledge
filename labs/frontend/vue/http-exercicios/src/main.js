import '@babel/polyfill'
import Vue from 'vue' //import assim é de node_modules
import App from './App.vue'

import './plugins/bootstrap-vue'
import './plugins/axios'

Vue.config.productionTip = false

new Vue({
  render: h => h(App),
}).$mount('#app')
