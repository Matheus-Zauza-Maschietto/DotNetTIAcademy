<template>
  <div id="cadastro-vendedor">
    <h3>Novo Vendedor</h3>
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
        <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarVendedor">Cadastrar</button>
    </div>
  </div>
</template>

<script>
import VendedorDataService from '../../services/VendedorDataService';

export default {
    name: "cadastrarFuncionarios",
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
        cadastrarVendedor(){
            var data = {
                Nome: this.cadastro.Nome,
                Login: this.cadastro.Login,
                Email: this.cadastro.Email,
                Telefone: this.cadastro.Telefone,
                Cpf: this.cadastro.Cpf,
                Senha: this.cadastro.Senha,

            }
            VendedorDataService.cadastrar(data)
                .then(() => {
                    this.$router.push('listar')
                })
        }
    }
}
</script>

<style>

</style>