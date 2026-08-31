<template>
    <div class="usuario">
        <h2>Usuários</h2>
        <hr>
        <!-- Onde as rotas aninhadas seram carregadas -->
        <router-view />
        <!-- <router-view name="oneMoreMenu"></router-view> -->
        <button sucesso @click="irParaInicio">Voltar</button>
    </div>
</template>

<script>
export default {
    methods: {
        irParaInicio() {
            // this.$router.push('/')
            // this.$router.push({ path: '/' })
            this.$router.push({ name: 'inicio' })
        }
    },
    beforeDestroy() {
        // console.log('antes de destruir usuario')
    }
}
</script>

<style>

</style>
