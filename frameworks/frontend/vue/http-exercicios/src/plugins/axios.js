import Vue from 'vue'
import axios from 'axios'

// Da para adicionar headers, interceptors, etc em outros lugares da aplicação com essa estrategia
// axios.defaults.baseURL = 'https://curso-vue-8bcfc-default-rtdb.firebaseio.com/'
// axios.defaults.headers.common['Authorization'] = 'abc123'
// axios.defaults.headers.get['Accepts'] = 'application/json'

Vue.use({
    // Da para criar várias instancias do axios para propositos especificos
    install(Vue) {
        // Vue.prototype.$http = axios
        Vue.prototype.$http = axios.create({
            baseURL: 'https://curso-vue-8bcfc-default-rtdb.firebaseio.com/',
            headers: {
                "Authorization": "abc123"
            }
        })

        Vue.prototype.$http.interceptors.request.use(config => {
            console.log(config.method)
            // if(config.method == 'post') {
            //     config.method = 'put'
            // }
            return config
        }, error => Promise.reject(error))

        Vue.prototype.$http.interceptors.response.use(res => {
            // const array = []
            // for(let chave in res.data) {
            //     array.push({ id: chave, ...res.data[chave] })
            // }

            // res.data = array
            return res
        }, error => Promise.reject(error))
    }
})