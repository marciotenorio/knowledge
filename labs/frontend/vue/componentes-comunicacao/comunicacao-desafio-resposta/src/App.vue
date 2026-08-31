<template>
  <div id="app">
    <UserList 
      :users="users"
      @showInfo= showInfo($event) 
    />
    <UserInfo 
      :currentUser="currentUser"
    />
  </div>
</template>

<script>
import UserList from '@/components/UserList.vue'
import UserInfo from '@/components/UserInfo.vue'

export default {
  name: 'App',
  components: {
    UserList,
    UserInfo
  },
  data() {
    return {
      currentUser: {},
      users: [
        {
          id: '01',
          name: 'Joelma',
          age: 46
        },
                {
          id: '02',
          name: 'Lorena',
          age: 22
        },
        {
          id: '03',
          name: 'Victor',
          age: 17
        },
        {
          id: '04',
          name: 'Jose',
          age: 70
        },
        {
          id: '05',
          name: 'Sônia',
          age: 74
        }
      ]
    }
  },
  methods: {
    showInfo(currentUser) {
      this.currentUser = currentUser;
    }
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
