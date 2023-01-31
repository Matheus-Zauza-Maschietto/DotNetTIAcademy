<template>
  <div id="cadastro-Cliente">
    <h3>Atualiazar Cliente</h3>
    <div class="form" style="padding: 1%;">
        <div>
            <label for="" class="form-label">Id</label>
            <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
        </div>
        <div>
            <label for="" class="form-label">Nome</label>
            <input type="text" class="form-control" required placeholder="Nome" v-model="Cliente.nome">
        </div>
        <div>
            <label for="" class="form-label">Login</label>
            <input type="text" class="form-control" required placeholder="Login" v-model="Cliente.login" disabled>
        </div>
        <div>
            <label for="" class="form-label">Email</label>
            <input type="text" class="form-control" required placeholder="Email" v-model="Cliente.email">
        </div>
        <div>
            <label for="" class="form-label">Senha</label>
            <input type="password" class="form-control" required v-model="updateCliente.senha">
        </div>
        <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarCliente">Cadastrar</button>
    </div>
  </div>
</template>

<script>
import ClienteDataService from '../../services/ClienteDataService.js';

export default {
    name: "ClienteCadastro",
    data(){
        return{
            Cliente: {
            },
            updateCliente: {
                nome: "",
                email: "",
                login: "",
                senha: ""
            }
        }
    },
    methods: {
        atualizarClienteData(){
            this.updateCliente.login = this.Cliente.login
            this.updateCliente.nome = this.Cliente.nome
            this.updateCliente.email = this.Cliente.email
        },
        obterCliente(id){
            ClienteDataService.obterPorId(id)
                .then((response) => {
                    console.log(response.data)
                    this.Cliente = response.data;
                })
        },
        atualizarCliente(){
            this.atualizarClienteData()
            ClienteDataService.atualizar(this.$route.params.id, this.updateCliente)
                .then(() => {
                    this.$router.push('/cliente/listar')
                })
        },

        
        
    },
    mounted(){
        this.obterCliente(this.$route.params.id)
    }
}
</script>

<style>

</style>