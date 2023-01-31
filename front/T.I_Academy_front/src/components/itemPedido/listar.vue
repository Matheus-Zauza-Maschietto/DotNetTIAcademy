<template>
  <div class="col-7 d-flex flex-column align-items-center">
    <h2>Pedido {{ Pedido.id }} - {{ Pedido.vendedor.nome }} - {{ Pedido.cliente.nome }}</h2>
    <p v-if="ItensPedido.length === 0">Esse pedido não possui nenhum item</p>
    <table class="table table-striped" v-else>
        <thead>
          <tr>
            <th scope="col">#</th>
            <th scope="col">Serviço</th>
            <th scope="col">Valor</th>
            <th scope="col">Quantidade</th>
            <th scope="col">SubTotal</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(item, index) in ItensPedido" :key="index">
            <th scope="row">{{ item.id }}</th>
            <td scope="row">{{ item.servico.nome }}</td>
            <td>{{ item.valor }}</td>
            <td>{{ item.quantidade }}</td>
            <td>R$ {{ item.valor* item.quantidade }}</td>
            <td>
              <button class="btn btn-success" @click="editarPedido(Pedido.id, item.id)">Editar</button>
              <button class="btn btn-danger" @click="excluirPedido(item)">Excluir</button>
            </td>
          </tr>
        </tbody>
    </table>
    <button class="btn btn-primary" @click="adicionarNovoItem(Pedido.id)">Adicionar novo item</button>
  </div>
</template>

<script>
import ItemPedidoDataService from '../../services/ItemPedidoDataService';
import PedidoDataService from '../../services/PedidoDataService.js';

export default {
  name: "listarItemPedidos",
  data() {
    return{
      ItensPedido: [],
      Pedido: {}
    }
  },
  methods: {
    obterItensPedido() {
      ItemPedidoDataService.listarPorPedido(this.$route.params.pedidoId)
        .then(response => this.ItensPedido = response.data)
    },

    obterPedidos() {
      PedidoDataService.obterPorId(this.$route.params.pedidoId)
        .then(response => this.Pedido = response.data)
    },

    editarPedido(idPedido, idItem){
      this.$router.push("/pedido/"+idPedido+"/itens-pedido/atualizar/"+idItem)
    },

    async excluirPedido(pedido){
      if(confirm(`Tem certeza que deseja excluir o pedido ${pedido.id}`)){
        await ItemPedidoDataService.deletar(pedido.id)
        this.$router.push("/pedido/listar")
      }
    },

    adicionarNovoItem(id){
      this.$router.push("/pedido/"+id+"/itens-pedido/cadastrar")
    }
  },
  computed: {
  },
  beforeMount(){
    this.obterItensPedido()
    this.obterPedidos()
  }
}

</script>

<style>

</style>



