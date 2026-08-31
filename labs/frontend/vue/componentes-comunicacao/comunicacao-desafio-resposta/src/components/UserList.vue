<template>
    <div id="UserList">
        <table>
            <tr>
                <th>#ID</th>
                <th>Nome</th>
            </tr>
            <tr 
                v-for="user in users" :key="user.id"
                @click="userSelected(user)">
                <td>{{ user.id }}</td>
                <td>{{ user.name }}</td>
            </tr>
        </table>
    </div>
</template>

<script>
export default {
    props: {
        users: {
            type: Array,
            required: true, 
        }
    },
    methods: {
        userSelected(event) {
            this.$emit('showInfo', event);
        }
    }
}
</script>

<style scoped>

#UserList {
    display: inline;
    float: left;
    width: 40%;
    margin-right: 5%;
}

table {
    width: 100%;
}

table, th, td {
    border-collapse: collapse;
    text-align: center;
    padding: 15px;
}

th, td {
    border-bottom: 1px solid #ddd;
}

tr:hover {
    background-color: yellow;
}


</style>