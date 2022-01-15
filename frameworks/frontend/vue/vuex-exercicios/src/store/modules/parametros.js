export default {
    state: {
        quantidade: 1,
        preco: 9.99,
        sequencia: 1
    },
    // Tem como objetivo apenas alterar o estado centralizado
    mutations: {
        setQuantidade(state, quantidade){
            state.quantidade = quantidade;
        },
        setPreco(state, preco){
            state.preco = preco
        },
        setSequencia(state, valor) {
            state.sequencia = valor;
        }
    }
}