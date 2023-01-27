<template>
  <div class="col-7">
    <table class="table table-striped">
        <thead>
          <tr>
            <th scope="col">#</th>
            <th scope="col">Nome</th>
            <th scope="col">Login</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(vendedor, index) in vendedores" :key="index">
            <th scope="row">{{ vendedor.id }}</th>
            <td>{{ vendedor.nome }}</td>
            <td>{{ vendedor.login }}</td>
            <td>
              <button class="btn btn-sucess"></button>
              <button class="btn btn-danger"></button>
            </td>
          </tr>
        </tbody>
    </table>
  </div>
</template>

<script>
import VendedorDataService from '../../services/VendedorDataService';

export default {
  data() {
    return{
      vendedores: []
    }
  },
  methods: {
    obterVendedores() {
      VendedorDataService.listar()
        .then(response => this.vendedores = response.data)
    }
  },
  mounted(){
    this.obterVendedores()
  }
}

</script>

<style>

</style>



