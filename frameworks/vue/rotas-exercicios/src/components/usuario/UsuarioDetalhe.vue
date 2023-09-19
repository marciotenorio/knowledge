<template>
    <div class="usuario-detalhe">
        <h3>Usuário Detalhe</h3>
        <hr>
        <p>Código: <strong>{{ id }}</strong></p>
        <!-- <router-link :to="`/usuario/${id}/editar`" tag="button" primario> -->
        <!-- <router-link :to="`/usuario/${$route.params.id}/editar`" tag="button" primario> -->
        <router-link :to="{ name:'editarUsuario', params: { id }, 
            query: { completo: true, lingua: 'en' },
            hash: '#rodape' }" tag="button" primario>
            Editar
        </router-link>
    </div>
</template>

<script>
export default {
    // Mesmo nome do parâmetro da rota
    props: ['id'],
    beforeRouteEnter(to, from , next) {
        // Não da por que neste ponto o componente nem foi criado ainda 
        // e o this não é do componente
        // console.log(this.id)
        console.log('dentro do componente -> usuario detalhe')
        // next( vm => {
            // aqui sim tenho acesso pois o componente ja foi criado
            // console.log(vm.id)
            
            // Cenário mais real
            // Verifica se ta autenticado por exemplo
        // })
            const auth = true
            auth ? next() : next(false)
    }
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
    // }
}
</script>

<style>

</style>
