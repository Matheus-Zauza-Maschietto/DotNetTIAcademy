import {createWebHistory, createRouter} from "vue-router"
import home from './components/home.vue'

import listarVendedor from './components/vendedor/listar.vue'
import cadastrarVendedor from './components/vendedor/cadastrar.vue'
import atualizarVendedor from './components/vendedor/atualizar.vue'

import listarCliente from './components/cliente/listar.vue'
import cadastrarCliente from './components/cliente/cadastrar.vue'
import atualizarCliente from './components/cliente/atualizar.vue'

import listarServico from './components/servico/listar.vue'
import cadastrarServico from './components/servico/cadastrar.vue'
import atualizarServico from './components/servico/atualizar.vue'

import listarPedido from './components/pedido/listar.vue'
import cadastrarPedido from './components/pedido/cadastrar.vue'
import atualizarPedido from './components/pedido/atualizar.vue'

import listarItemPedido from './components/itemPedido/listar.vue'
import cadastrarItemPedido from './components/itemPedido/cadastrar.vue'
import atualizarItemPedido from './components/itemPedido/atualizar.vue'


const routes = [
    {
        path: "/",
        component: home
    },
    {
        path: "/vendedor/listar",
        component: listarVendedor
    },
    {
        path: "/vendedor/cadastrar",
        component: cadastrarVendedor
    },
    {
        path: "/vendedor/atualizar/:id",
        component: atualizarVendedor
    },
    
    {
        path: "/cliente/listar",
        component: listarCliente
    },
    {
        path: "/cliente/cadastrar",
        component: cadastrarCliente
    },
    {
        path: "/cliente/atualizar/:id",
        component: atualizarCliente
    },
    
    {
        path: "/servico/listar",
        component: listarServico
    },
    {
        path: "/servico/cadastrar",
        component: cadastrarServico
    },
    {
        path: "/servico/atualizar/:id",
        component: atualizarServico
    },

    {
        path: "/pedido/listar",
        component: listarPedido
    },
    {
        path: "/pedido/cadastrar",
        component: cadastrarPedido
    },
    {
        path: "/pedido/atualizar/:id",
        component: atualizarPedido
    },

    {
        path: "/pedido/:pedidoId/itens-pedido/listar",
        component: listarItemPedido
    },
    {
        path: "/pedido/:pedidoId/itens-pedido/cadastrar",
        component: cadastrarItemPedido
    },
    {
        path: "/pedido/:pedidoId/itens-pedido/atualizar/:itemPedidoId",
        component: atualizarItemPedido
    },
]

const router = createRouter({
    history: createWebHistory(),
    routes
})
export default router