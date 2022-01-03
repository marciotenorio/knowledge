import Vue from 'vue'
export default new Vue({
    // Substituindo o $on e $emit para usar barramento.alterarIdade ou quandoIdadeMudar
    methods: {
        alterarIdade(idade) {
            this.$emit('idadeMudou', idade)
        },
        quandoIdadeMudar(callback) {
            this.$on('idadeMudou', callback)
        }
    }
})

// Para usar o event bus se emite o evento no barramento normal eventBus.$emit('nomeDaFuncao', data)
// e ouve ele no componente que você quer fazendo barramento.$on('nomeDaFuncao', callback)