import {createWebHistory, createRouter} from "vue-router"
import listar from './components/vendedor/listar.vue'
import home from './components/home.vue'

const routes = [
    {
        path: "/",
        component: home
    },
    {
        path: "/vendedor/listar",
        component: listar
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})
export default router