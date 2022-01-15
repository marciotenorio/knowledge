import Vuex from 'vuex'
import Vue from 'vue'

import carrinho from '@/store/modules/carrinho'
import parametros from '@/store/modules/parametros'
import * as getters from '@/store/modules/getters' 


Vue.use(Vuex)

export default new Vuex.Store({
    // Só o estado que não está da mesma forma que explicado abaixo, 
    // por exemplo em carrinho fica state.carrinho.produtos
    // state: {
    //     carrinho: {
    //         produtos: []
    //     },
    //     parametros: {
    //         preco: 1,
    //         quantidade:1
    //     }
    // }

    // Todos os métodos que estão dentro dos getter, mutations e actions
    // serão coloados diretamente na store, mesma forma como estava anterior
    // com tudo definido junto. Logo não posso ter funções com o mesmo nome
    // pra resolver isso preciso de namespace
    state: { nome: 'Márcio', sobrenome: 'Tenório' },
    // Se tiver mais pode fazer assim
    getters: {
        ...getters
    },
    // getters,
    modules: { carrinho, parametros}
})