<template>
    <div class="container">
        <h1>Componente Usuário</h1>
        <p>Esse é um componente muito legal!</p>
        <p>Nome é <strong>{{ nome }}</strong></p>
        <p>Idade é <strong>{{ idade }}</strong></p>
        <button @click="alterarNome">Alterar Nome</button>
        <hr>
        <div class="componentes">
            <app-usuario-info 
                :nome="nome"
                :idade="idade"
                @nomeMudou="nome = $event"
                :reiniciarFn="reiniciarNome" />
            <app-usuario-editar 
                :idade="idade" />
        </div>
    </div>
</template>

<script>
import AppUsuarioInfo from './UsuarioInfo'
import AppUsuarioEditar from './UsuarioEditar'

export default {
    components: { AppUsuarioInfo, AppUsuarioEditar },
    data() {
        return {
            nome: 'Pedro',
            idade: 21
        }
    },
    methods: {
        // Comunicação entre irmãos pode ser feita emitindo um evento que muda algo no pai
        // e então ele atualiza os filhos, ou seja, se comunica apartir do componente pai
        alterarNome() {
            this.nome = 'Ana'
        },
        reiniciarNome() {
            // Passando uma função callback para mudar o pai, mas ela é chamada no
            // filho através de props
            this.nome = 'Pedro'
        },
        nomeMudou(event) {
            // @nomeMudou="nomeMudou($event)" outra forma de chamar a funcao do evento
            // la em cima
            this.nome = event
        }
        // changeAge() {
        //      mudando idade por callback passado como props
        //     this.idade = 24;
        // }
    }
}
</script>

<style scoped>
    .container {
        background-color: #27363b;
        color: #fff;
        padding: 10px;
    }

    .container hr {
        margin: 20px 10px;
    }

    .componentes {
        display: flex;
    }

    .componentes > * {
        margin: 10px;
    }
</style>
