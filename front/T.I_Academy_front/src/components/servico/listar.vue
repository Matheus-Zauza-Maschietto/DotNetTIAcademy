<template>
  <div class="col-7">
    <table class="table table-striped">
        <thead>
          <tr>
            <th scope="col">#</th>
            <th scope="col">Nome</th>
            <th scope="col">Descricao</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(servico, index) in Servicos" :key="index">
            <th scope="row">{{ servico.id }}</th>
            <td>{{ servico.nome }}</td>
            <td>
              <button class="btn btn-success" @click="editarServico(servico.id)">Editar</button>
              <button class="btn btn-danger" @click="excluirServico(servico)">Excluir</button>
            </td>
          </tr>
        </tbody>
    </table>
  </div>
</template>

<script>
import ServicoDataService from '../../services/ServicoDataService.js';

export default {
  name: "listarServicos",
  data() {
    return{
      Servicos: []
    }
  },
  methods: {
    obterServicos() {
      ServicoDataService.listar()
        .then(response => this.Servicos = response.data)
    },

    editarServico(id){
      this.$router.push("/servico/atualizar/"+id)
    },

    async excluirServico(cliente){
      if(confirm(`Tem certeza que deseja excluir o cliente ${cliente.nome}`)){
        await ServicoDataService.deletar(cliente.id)
        this.obterServicos();
      }
    }
  },
  mounted(){
    this.obterServicos()
  }
}

</script>

<style>

</style>



