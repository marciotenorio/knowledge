<template>
    <Painel titulo="Loja Virtual" verde>
        <div class="loja">
            <span>Adicionar</span>
            <input type="number" v-model.number="quantidade">
            <span>itens de <strong>R$</strong></span>
            <input type="number" v-model.number="preco">
            <button @click="adicionar">Agora!</button>
        </div>
    </Painel>
</template>

<script>
import { mapActions } from 'vuex'

export default {
    computed: {
        quantidade() {
            return this.$store.state.parametros.quantidade;
        },
        preco() {
            return this.$store.state.parametros.preco;
        },
        sequencia: {
            get() {
                return this.$store.state.parametros.sequencia;
            },
            set(valor) {
                this.$store.commit('setSequencia', valor)
            }
        }        
    },
    methods: {
        // Mesmas forma dos getters
        // mapMutations vem sempre em methods
        // ...mapMutations(['adicionarProduto']),

        // Adicinou namespaced true e agora preciso chamar ele antes
        // de passar a lista de actions
        ...mapActions('carrinho', ['adicionarProduto']),

        // So funciona por que ta no raiz, dai nao preciso passar
        // namespace 'carrinho' antes
        // ...mapActions(['adicionarProduto']),

        // mapActions faz isso
        // adicionarProduto(produto) {
        //     this.$store.dispatch('adicionarProduto', produto);
        // },

        adicionar() {
            const produto = {
                id: this.sequencia,
                nome: `Produto ${this.sequencia}`,
                quantidade: this.quantidade,
                preco: this.preco
            }
            this.sequencia++
            // eslint-disable-next-line
            console.log(produto)

            // this.$store.state.produtos.push(produto)

            // this.$commit chama a mutation passada no primeiro parâmetro
            // this.$store.commit('adicionarProduto', produto)

            // Atraves do mapMutations
            // Atraves do mapActions
            this.adicionarProduto(produto)

            // this.$store.dispatch('adicionarProduto', produto);

            // eslint-disable-next-line
            console.log(this.$store.getters.getNome)
            // eslint-disable-next-line
            console.log(this.$store.getters.getNomeCompleto)
        }
    }
}
</script>

<style>
    .loja {
        display: flex;
        justify-content: center;
    }

    .loja > * {
        margin: 0px 10px;
    }

    input {
        font-size: 2rem;
        width: 90px;
    }
</style>
