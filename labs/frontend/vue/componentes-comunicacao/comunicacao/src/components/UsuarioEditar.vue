<template>
    <div class="componente">
        <h2>Alterar os Dados de Usuário</h2>
        <p>Edite as informações</p>
        <p>Idade do Usuário: <strong>{{ idade }}</strong></p>
        <button @click="alterarIdade">Alterar Idade</button>
        <!-- Poderia passar changeAge aqui que iria funcionar -->
        <!-- Poderia emitir um evento e caputa-lo em Usuario -->
    </div>
</template>

<script>
import barramento from '@/barramento'

export default {
    props: ['idade', 'changeAge'],
    methods: {
        alterarIdade() {
            // Da ruim por que você está mudando uma prop diretamente e como no Vue 2
            // elas são one-way bind o pai pode não ser notificado
            // usar sempre $emit ou callback passado numa props
            this.idade += 1
            barramento.alterarIdade(this.idade)

        }
    }
}
</script>

<style scoped>
    .componente {
        flex: 1;
        background-color: #98b99a;
        color: #fff;
    }
</style>
