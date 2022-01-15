export default {
    namespaced: true,
    state: {
        produtos: []
    },
    getters: {
        // eslint-disable-next-line
        valorTotal(state, getters, rootState) {
            return state.produtos.map( p => p.quantidade * p.preco)
                .reduce((total, atual) => total + atual, 0)
        }
    },
    // Tem como objetivo apenas alterar o estado centralizado
    mutations: {
        // Posso passar so o state e ter algo hardcoded e também posso receber o payload
        adicionarProduto(state, payload) {
            state.produtos.push(payload)
        }
    },
    // Para por regras de negócio antes de alterar o estado chamando
    // as mutations, se tiver que trabalhar com async é aqui e não 
    // nas mutations, embora elas sejam async só coloque código syn
    actions: {
        // context seria o 'this' para chamar o commit
        // adicionarProduto(context, payload){
        //     setTimeout(() => {
        //         context.commit('adicionarProduto', payload)
        //     }, 1000)
        // }

        // Dentro do módulo o state que irei acessar é o do carrinho
        // se quiser o global se usa o rootSate
        // eslint-disable-next-line
        adicionarProduto({ commit, state, rootState }, payload){
            setTimeout(() => {
                // mutations tem o mesmo nome, só por isso é igual
                commit('adicionarProduto', payload)
            }, 1000)
        }

        // adicionando método como root
        // adicionarProduto: {
        //     root: true,
        //     handler({commit}, payload) {
        //         setTimeout(() => {
        //             // mutations tem o mesmo nome, só por isso é igual
        //             commit('adicionarProduto', payload)
        //         }, 1000)                
        //     }
        // }
        
    } 
}