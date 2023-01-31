<template>
  <div id="atualizar-pedido">
    <h3>Atualiazar Pedido</h3>
    <div class="form" style="padding: 1%;">
        <div>
            <label for="" class="form-label">Id</label>
            <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
        </div>
        <div>
            <label for="" class="form-label">Vendedor Atual</label>
            <input type="text" class="form-control" required placeholder="Id" :value="vendedorAtual" disabled>
        </div>
        <div>
            <label for="" class="form-label">Vendedor Atualizado</label>
            <br>
            <select name="vendedor" id="vendedor" v-model="updatePedido.VendedorId">
                <option v-for="(vendedor, index) in vendedores" :key="index" :value="vendedor.id">{{ vendedor.nome }}</option>
            </select>
        </div>
        <div>
            <label for="" class="form-label">Cliente Atual</label>
            <input type="text" class="form-control" required placeholder="Id" :value="clienteAtual" disabled>
        </div>
        <div>
            <label for="" class="form-label">Cliente Atualizado</label>
            <br>
            <select name="vendedor" id="vendedor" v-model="updatePedido.ClienteId">
                <option v-for="(cliente, index) in clientes" :key="index" :value="cliente.id">{{ cliente.nome }}</option>
            </select>
        </div>
        <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarPedido">Cadastrar</button>
    </div>
  </div>
</template>

<script>
import PedidoDataService from '../../services/PedidoDataService'
import ClienteDataService from '../../services/ClienteDataService'
import VendedorDataService from '../../services/VendedorDataService'

export default {
    name: "PedidoUpdate",
    data(){
        return{
            pedido: {
            },
            vendedores:{
            },
            clientes:{
            },
            updatePedido: {
                VendedorId: "",
                ClienteId: ""
            },
            vendedorAtual: "",
            clienteAtual: ""
        }
    },
    methods: {
        atualizarPedidoData(){
            this.updatePedido.VendedorId = this.vendedor.id
            this.updatePedido.ClienteId = this.cliente.id
        },

        obterPedido(id){
            PedidoDataService.obterPorId(id)
                .then((response) => {
                    this.pedido = response.data;
                })
        },

        obterClientes(){
            ClienteDataService.listar()
                .then((response) => {
                    this.clientes = response.data
                })
        },

        obterVendedores(){
            VendedorDataService.listar()
                .then((response) => {
                    this.vendedores = response.data
                })
        },

        atualizarPedido(){
            this.atualizarVendedorData()
            PedidoDataService.atualizar(this.$route.params.id, this.updateVendedor)
                .then(() => {
                    this.$router.push('vendedor/listar')
                })
        },
        // Resolver isso amanhã
        obterPedidoEnvolvidos(clientes, vendedores){
            clientes.forEach(element => {
                if(element.id == pedido.ClienteId){
                    this.vendedorAtual = element.nome
                }
            });
            vendedores.forEach(element => {
                if(element.id == pedido.vendedorId){
                    this.vendedorAtual = element.nome
                }
            });
        }

        
        
    },
    mounted(){
        this.obterPedido(this.$route.params.id)
        this.obterVendedores()
        this.obterClientes()
        this.obterPedidoEnvolvidos(this.clientes, this.vendedores)
    }
}
</script>

<style>

</style>