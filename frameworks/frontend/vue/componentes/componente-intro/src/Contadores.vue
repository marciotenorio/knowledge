<template>
    <div class="contadores">
        <h1>Contadores</h1>
        <app-contador v-for="c in 5" :key="c" />
        <!-- Childrens have the style of Contadores but yours grandchilds don't have
        If have conflitct with style of this component and the direct childs, prevails 
        parent style -->
    </div>
</template>

<script>
import Contador from './Contador.vue'

export default {
    components: { 'app-contador': Contador }
}
</script>

<style scoped>
    div {
        border: 1px solid red;
    }
</style>
