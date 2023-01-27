<template>
  <div id="cadastro-vendedor">
    <h3>Atualiazar Vendedor</h3>
    <div class="form" style="padding: 1%;">
        <div>
            <label for="" class="form-label">Nome</label>
            <input type="text" class="form-control" required placeholder="Nome" v-model="cadastro.Nome">
        </div>
        <div>
            <label for="" class="form-label">Login</label>
            <input type="text" class="form-control" required placeholder="Login" v-model="cadastro.Login">
        </div>
        <div>
            <label for="" class="form-label">Email</label>
            <input type="text" class="form-control" required placeholder="Email" v-model="cadastro.Email">
        </div>
        <div>
            <label for="" class="form-label">Telefone</label>
            <input type="text" class="form-control" required placeholder="Telefone" v-model="cadastro.Telefone">
        </div>
        <div>
            <label for="" class="form-label">Cpf</label>
            <input type="text" class="form-control" required placeholder="Cpf" v-model="cadastro.Cpf">
        </div>
        <div>
            <label for="" class="form-label">Senha</label>
            <input type="password" class="form-control" required v-model="cadastro.Senha">
        </div>
        <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarVendedor()">Cadastrar</button>
    </div>
  </div>
</template>

<script>
import VendedorDataService from '../../services/VendedorDataService';

export default {
    name: "FuncionarioCadastro",
    data(){
        return{
            cadastro: {
                "Nome": "",
                "Email": "",
                "Telefone": "",
                "Cpf": "",
                "Login": "",
                "Senha": ""
            }
        }
    },
    methods: {
        obterVendedor(id){
            console.log(id)
            VendedorDataService.obterPorId(id)
                .then(() => {
                    this.vendedor = response.data;
                })
        },
        atualizarVendedor(){
            console.log("teste")
            VendedorDataService.atualizar(this.vendedor.id, this.vendedor)
                .then(() => {
                    this.$router.push('listar')
                })
        },
        mounted(){
            this.obterVendedor(this.$route.params.id)
        }
    }
}
</script>

<style>

</style>