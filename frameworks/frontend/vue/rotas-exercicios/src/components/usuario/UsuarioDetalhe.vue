<template>
    <div class="usuario-detalhe">
        <h3>Usuário Detalhe</h3>
        <hr>
        <p>Código: <strong>{{ id }}</strong></p>

        <!-- <p><strong>Código:</strong> {{ id }}</p>
         :to="`/usuario/${id}/editar`"
        <router-link tag="button" primario
            :to="{ name: 'editarUsuario', params: { id },
                query: { completo: false, lingua: 'en' },
                hash: '#rodape' }">
            Editar
        </router-link> -->
    </div>
</template>

<script>
export default {
    // Mesmo nome do parâmetro da rota
    props: ['id'],
    // data() {
    //     return {
    //         id: this.$route.params.id
    //     }
    // },
    // watch: {
    //     // Monitorando mudança dos parametros da rota quando você continua no mesmo componente
    //     // to this.$route novo e from o antigo
    //     $route(to, from){
    //         this.id = to.params.id;
    //     }
    // },
    // beforeRouteEnter(to, from, next) {
    //     // console.log(this.id)
    //     console.log('dentro do componente -> usuário detalhe')
    //     // next(vm => {
    //     //     console.log(vm.id)
    //     // })
    //     const autenticado = true
    //     autenticado ? next() : next(false)
    // }
    // data() {
    //     return {
    //         id: this.$route.params.id
    //     }
    // },
    // watch: {
    //     $route(to, from) {
    //         this.id = to.params.id
    //     }
    // },
}
</script>

<style>

</style>
