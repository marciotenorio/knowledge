<template>
    <Painel titulo="Parâmetros" vermelho>
        <div class="parametros">
            <span>
                <strong>Quantidade Padrão: </strong> 
                <input type="number" v-model="quantidade">
            </span>
            <span>
                <strong>Preço Padrão: </strong>
                <input type="number" v-model="preco">
            </span>
        </div>
    </Painel>
</template>

<script>
export default {
    computed: {
        quantidade: {
            get() {
                return this.$store.state.parametros.quantidade;
            },
            set(quantidade){
                // commit fica no raiz por isso nao precisa de .parametros
                this.$store.commit('setQuantidade', quantidade);
            }
        },
        preco: {
            get() {
                return this.$store.state.parametros.preco;
            },
            set(preco) {
                // commit fica no raiz por isso nao precisa de .parametros
                this.$store.commit('setPreco', preco);
            }
        }
    }
}
</script>

<style>
    .parametros {
        display: flex;
        justify-content: space-around;
    }
</style>
