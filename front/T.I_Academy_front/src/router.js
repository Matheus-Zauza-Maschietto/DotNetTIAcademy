import {createWebHistory, createRouter} from "vue-router"
import listar from './components/vendedor/listar.vue'
import home from './components/home.vue'
import cadastrar from './components/vendedor/cadastrar.vue'
import atualizar from './components/vendedor/atualizar.vue'


const routes = [
    {
        path: "/",
        component: home
    },
    {
        path: "/vendedor/listar",
        component: listar
    },
    {
        path: "/vendedor/cadastrar",
        component: cadastrar
    },
    {
        path: "/vendedor/atualizar/:id",
        component: atualizar
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})
export default router