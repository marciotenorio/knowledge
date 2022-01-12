import Vue from 'vue'
import Router from 'vue-router'
import Inicio from './components/Inicio'
// import Menu from './components/template/Menu'
// import MenuAlt from './components/template/MenuAlt'
import Usuario from '@/components/usuario/Usuario'
import UsuarioLista from '@/components/usuario/UsuarioLista'
import UsuarioDetalhe from '@/components/usuario/UsuarioDetalhe'
import UsuarioEditar from '@/components/usuario/UsuarioEditar'

// import Usuario from './components/usuario/Usuario'
// import UsuarioLista from './components/usuario/UsuarioLista'
// import UsuarioDetalhe from './components/usuario/UsuarioDetalhe'
// import UsuarioEditar from './components/usuario/UsuarioEditar'

Vue.use(Router)

// const Usuario = () => import(/* webpackChunkName: "usuario" */'./components/usuario/Usuario')
// const UsuarioLista = () => import(/* webpackChunkName: "usuario" */'./components/usuario/UsuarioLista')
// const UsuarioDetalhe = () => import(/* webpackChunkName: "usuario" */'./components/usuario/UsuarioDetalhe')
// const UsuarioEditar = () => import(/* webpackChunkName: "usuario" */'./components/usuario/UsuarioEditar')

const router = new Router({
    mode: 'history',
    routes: [{
        path: '/',
        component: Inicio
    }, {
        path: '/usuario', 
        component: Usuario,
        props: true,
        children: [
            {path: '', component: UsuarioLista},
            {path: ':id', component: UsuarioDetalhe, props: true},
            {path: ';id/editar', component: UsuarioEditar, props: true},
            
        ]
    }]
    // Hashmode é feita a requisição para o localhost, esse então passa pelo index.html, carrega o app.js 
    // que tem o Vue e depois do Vue carregado via js o Vue pega o resto da url depois do #/ e carrega o componente 
    // Já no Historymode é enviado toda a url, só que por padrão isso não passa pelo index.html 
    // precisa configurar (no backend) para que ele passe e então seja carregado o componente
    // da pra usar o histórico do browser
    // https://router.vuejs.org/guide/essentials/history-mode.html#example-server-configurations
    // mode: 'history',
    // scrollBehavior(to, from, savedPosition) {
    //     if(savedPosition) {
    //         return savedPosition
    //     } else if(to.hash) {
    //         return { selector: to.hash }
    //     } else {
    //         return { x: 0, y: 0 }
    //     }
    // },
    // routes: [{
    //     name: 'inicio',
    //     path: '/',
    //     // component: Inicio
    //     components: {
    //         default: Inicio,
    //         menu: Menu
    //     }
    // }, {
    //     path: '/usuario',
    //     // component: Usuario,
    //     components: {
    //         default: Usuario,
    //         menu: MenuAlt,
    //         menuInferior: MenuAlt
    //     },
    //     props: true,
    //     children: [
    //         { path: '', component: UsuarioLista },
    //         { path: ':id', component: UsuarioDetalhe, props: true,
    //             beforeEnter: (to, from, next) => {
    //                 console.log('antes da rota -> usuário detalhe')
    //                 next()
    //             } },
    //         { path: ':id/editar', component: UsuarioEditar, props: true,
    //             name: 'editarUsuario' },
    //     ]
    // }, {
    //     path: '/redirecionar',
    //     redirect: '/usuario'
    // }, {
    //     path: '*',
    //     redirect: '/'
    // }]
})

// router.beforeEach((to, from, next) => {
//     console.log('antes das rotas -> global')
//     next()
// })

export default router