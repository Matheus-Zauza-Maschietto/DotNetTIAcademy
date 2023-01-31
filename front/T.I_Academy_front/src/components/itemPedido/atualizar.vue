<template>
    <div id="cadastro-vendedor">
      <h3>Atualizar pedido</h3>
      <div class="form" style="padding: 1%;">
          <h2>Pedido {{ this.pedidoId }}</h2>
          <div>
              <label for="" class="form-label">Serviços Atual</label>
              <br>
              <input type="text" v-model="ServicoAtual.nome" class="form-control" disabled>
          </div>
          <div>
              <label for="" class="form-label">Serviços Atualizado</label>
              <br>
              <select name="servicos" id="servicos" v-model="cadastro.servicoId" class="form-select">
                  <option v-for="(servico, index) in Servicos" :key="index" :value="servico.id">{{ servico.nome }}</option>
              </select>
          </div>
          <div>
              <label for="" class="form-label">Quantidade</label>
              <br>
              <input type="number" v-model="cadastro.quantidade" class="form-control" min="1">
          </div>
          <div>
              <label for="" class="form-label">Valor</label>
              <br>
              <input type="number" v-model="cadastro.valor" class="form-control" min="1">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="AtualizarItemPedido">Atualizar</button>
      </div>
    </div>
  </template>
  
  <script>
  import ServicoDataService from '../../services/ServicoDataService';
  import ItemPedidioDataService from '../../services/ItemPedidoDataService';  
  
  export default {
      name: "cadastrarItemPedidos",
      data(){
          return{
              cadastro: {
                pedidoId: this.$route.params.itemPedidoId,
                servicoId: "",
                quantidade: "",
                valor: ""
              },
              ServicoAtual: {},
              Servicos: [],
          }
      },
      methods: {
          AtualizarItemPedido(){
              if(Number(this.cadastro.quantidade) <= 0 || Number(this.cadastro.valor) <= 0){
                  alert("Quantidade e valor devem ter um valor minimo de 1")
              }
              else{
                  ItemPedidioDataService.atualizar(this.cadastro.pedidoId, this.cadastro)
                  .then(() => {
                      this.$router.push('/pedido/'+this.$route.params.pedidoId+'/itens-pedido/listar')
                  })
              }
          },
          
      },
      mounted(){
          ItemPedidioDataService.obterPorId(this.$route.params.itemPedidoId)
          .then((response) => {
            this.cadastro = response.data
          })

          ServicoDataService.listar()
          .then((response) => {
              this.Servicos = response.data
              this.Servicos = this.Servicos.filter(item =>
              {
                if(item.id == this.cadastro.servicoId){
                    this.ServicoAtual = item
                    return false
                }
                return true
              })
          })

      }
  }
  </script>
  
  <style>
  
  </style>