<template>
    <div id="UserInfo">
        <div v-if="Object.keys(currentUser).length > 0">
            <h2>ID: {{ currentUser.id }}</h2>
            <h2>Nome: {{ currentUser.name }}</h2>
            <h2>Idade: {{ currentUser.age }}</h2>
        </div>
        <div v-else>
            <h2>Usuário não selecionado</h2>
        </div>
    </div>
</template>

<script>
export default {
    props: {
        currentUser: {
            type: Object,
            default() {
                return {};
            }
        },
        teste: {
            type: String
        }
    }

}
</script>

<style scoped>
#UserInfo {
    width: 40%;
    border: 1px solid;
    display: inline;
    float: right;
    margin-left: 5%;
}

#UserInfo.div {
    height: 100%;
}



</style>