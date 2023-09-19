<template>
    <div>
        <Rotulo nome="Nome">
            <input 
                @input="inputFirstName"
                :value="value.firstName" 
                type="text">
        </Rotulo>
        <Rotulo nome="Sobrenome">
            <input
                @input="inputLastName"
                :value="value.lastName" 
                type="text">
        </Rotulo>
    </div>

</template>

<script>
import Rotulo from '@/components/Rotulo.vue'

export default {

    components: { Rotulo },
    props: {
        value: {
            type: Object,
            required: true
        }
    },
    methods: {
        inputFirstName(event) {
            this.$emit('input', { 
                firstName: event.target.value,
                lastName: this.value.lastName
             })
        },
        inputLastName(event) {
            this.$emit('input', { 
                firstName: this.value.firstName,
                lastName: event.target.value
             })
        }
    }
}
</script>

<style>

</style>