<template>
    <div class="componente">
        <h2>As Informações de Usuário</h2>
        <p>Vários detalhes...</p>
        <p>Nome do Usuário: <strong>{{ inverterNome() }}</strong></p>
        <p>Idade do Usuário: <strong>{{ idade }}</strong></p>
        <button @click="reiniciarNome">Reiniciar Nome</button>
        <button @click="reiniciarFn()">Reiniciar Nome (Callback)</button>
    </div>
</template>

<script>
import barramento from '@/barramento'

export default {
    props: {
        nome: {
            // https://vuejs.org/v2/guide/components-props.html
            type: String,
            // required: true,
            // default: function() {
            //     return Array(10).fill(0).join(',')
            // }
            //validator: function(value) {
            //    true or false
            //}
            default: 'Anônimo'
        },
        reiniciarFn: Function,
        idade: Number
    },
    methods: {
        inverterNome() {
            return this.nome.split('').reverse().join('')
        },
        reiniciarNome() {
            // Emite um evento personalizado, no caso, nomeMudou que sera capturado no
            // componente pai (Usuario).
            // https://vuejs.org/v2/guide/components-custom-events.html
            // https://v3.vuejs.org/guide/migration/v-model.html#_2-x-syntax
            // https://vuejs.org/v2/api/#vm-emit
            // this.nome = 'Pedro'
            this.$emit('nomeMudou', 'Pedro')
        }
    },
    created() {
        barramento.quandoIdadeMudar(idade => {
            this.idade = idade
        })
    }
}
</script>

<style scoped>
    .componente {
        flex: 1;
        background-color: #ec485f;
        color: #fff;
    }
</style>
