<template>
    <div class="citacoes">
        <span>
            <button @click="numero--">&lt;</button>
            <button @click="numero++">&gt;</button>
        </span>
        <Citacao>
            <!-- Pode ter mais de um elemento para o mesmo slot nomeado -->
            <h1 slot="autor">{{ citacoes[indice].autor }}</h1>
            <!-- Se não tiver slot nomeado vai para o default e pode ir mais de um elemento -->
            <p>{{ citacoes[indice].texto }}</p>
            <h6 slot="fonte">{{ citacoes[indice].fonte }}</h6>
        </Citacao>
    </div>
</template>

<script>
import Citacao from './Citacao.vue'

export default {
    components: { Citacao },
    data() {
        return {
            numero: 0,
            citacoes: [{
                fonte: 'Jornal do Empreendedor',
                texto: 'Lembre-se sempre que você é absolutamente único. Assim como todos os outros.',
                autor: 'Margaret Mead'
            }, { 
                fonte: 'Frases de Mãe',
                texto: 'Isso não é um quarto, é um chiqueiro.',
                autor: 'Roberta'
            }, {
                fonte: 'Frases de Pai',
                texto: 'Vou contar até 3! 1, 2, 2...',
                autor: 'Gustavo'
            }]
        }
    },
    computed: {
        indice() {
            return Math.abs(this.numero % 3)
        }
    },
    created() {
        //eslint-disable-next-line
        console.log('created')
    },
    destroyed() {
        //eslint-disable-next-line
        console.log('destroyed')
    },
    activated() {
        // eslint-disable-next-line
        console.log('activated')
    },
    deactivated() {
        // eslint-disable-next-line
        console.log('deactivated')
    }
}
</script>

<style scoped>
    /* Da pra aplicar estilo nos componentes passados no slot, se tiver estilo aqui e no component
    vai haver conflito */
    .citacoes {
        display: flex;
        flex-direction: column;
        align-items: center;
    }
</style>
