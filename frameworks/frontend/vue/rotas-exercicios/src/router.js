import Vue from 'vue'
import Router from 'vue-router'
import Inicio from './components/Inicio'
import Menu from './components/template/Menu'
import MenuAlt from './components/template/MenuAlt'

// import Usuario from '@/components/usuario/Usuario'
// import UsuarioLista from '@/components/usuario/UsuarioLista'
// import UsuarioDetalhe from '@/components/usuario/UsuarioDetalhe'
// import UsuarioEditar from '@/components/usuario/UsuarioEditar'

Vue.use(Router)

// Imports dinamicos 
// webpackChunkName serve para ao inves de fazer prefetch e chamar 0.js 1.js
// chamar um unico arquivo nomeado nesse caso "usuario" com todos esses imports
// é interessante agrupar componentes que tem a ver, pois da problema de performance 
// com muitos requests
const Usuario = () => import(/* webpackChunkName: "usuario" */'./components/usuario/Usuario')
const UsuarioLista = () => import(/* webpackChunkName: "usuario" */'./components/usuario/UsuarioLista')
const UsuarioDetalhe = () => import(/* webpackChunkName: "usuario" */'./components/usuario/UsuarioDetalhe')
const UsuarioEditar = () => import(/* webpackChunkName: "usuario" */'./components/usuario/UsuarioEditar')

const router = new Router({
    // Hashmode é feita a requisição para o localhost, esse então passa pelo index.html, carrega o app.js 
    // que tem o Vue e depois do Vue carregado via js o Vue pega o resto da url depois do #/ e carrega o componente 
    // Já no Historymode é enviado toda a url, só que por padrão isso não passa pelo index.html 
    // precisa configurar (no backend) para que ele passe e então seja carregado o componente
    // da pra usar o histórico do browser
    // https://router.vuejs.org/guide/essentials/history-mode.html#example-server-configurations

    mode: 'history',
    scrollBehavior(to, from, savedPosition) {
        if(savedPosition){
            return savedPosition
        }
        else if(to.hash){
            return { selector: to.hash }
        }
        return { x: 0, y: 0}
        // return { x: 0, y: 1000}
    },
    routes: [{
        // component: Inicio,
        //Usa name por convenciencia para rotas com path longo
        path: '/',
        name: 'inicio',
        components: {
            default: Inicio,
            menu: Menu
        }
    }, {
        path: '/usuario', 
        // component: Usuario,
        components: {
            default: Usuario,
            menu: MenuAlt,
            menuInferior: Menu
        },
        props: true,
        children: [
            {path: '', component: UsuarioLista
            // router-view nomeado quando tem children tem que passar nele 
            /*components: { default: UsuarioLista, oneMoreMenu: Menu }*/ 
            },
            {
                path: ':id', component: UsuarioDetalhe, props: true,
                // Antes de entrar em toda rota
                beforeEnter: (to, from, next) => {
                    console.log('Antes da rota -> usuário detalhe')
                    next()
                }
            },
            {path: ':id/editar', component: UsuarioEditar, props: true, name: 'editarUsuario'},
            
        ]
    },{
        path: '/redirecionar',
        redirect: '/usuario'
    },{
        // Se na rota doida que não existe tiver uma query string ela
        // vai para o redirect
        path: '*',
        redirect: '/'
    }]
})
// https://router.vuejs.org/guide/advanced/navigation-guards.html
// Antes de entrar em toda rota
router.beforeEach((to, from, next) => {
    console.log('antes das rotas -> global')
    // if(to.path !== '/usuario'){
    //     next('/usuario')
    //     next(false)
    // }
    // else{
    //     next()
    // }
    // Se não usar o next ele não navega
    next()
})

export default router