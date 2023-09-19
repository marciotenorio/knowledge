new Vue({
    el: '#desafio',
    data: {
        valor: ''
    },
    methods: {
        showAlert(){
            alert('Botão clicado')
        },
        populateValue(event){
            this.valor = event.target.value;
        }
    }
})