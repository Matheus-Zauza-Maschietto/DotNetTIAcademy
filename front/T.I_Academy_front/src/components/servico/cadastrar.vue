<template>
  <div id="cadastro-servico">
    <h3>Novo Servico</h3>
    <div class="form" style="padding: 1%;">
        <div>
            <label for="" class="form-label">Nome</label>
            <input type="text" class="form-control" required placeholder="Nome" v-model="cadastro.Nome">
        </div>
        <div>
            <label for="" class="form-label">Descrição</label>
            <textarea name="" id="" cols="40" rows="10" required placeholder="Descricao" v-model="cadastro.Descricao" class="form-control"></textarea>
        </div>
        <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarServico">Cadastrar</button>
    </div>
  </div>
</template>

<script>
import ServicoDataService from '../../services/ServicoDataService';

export default {
    name: "cadastrarClientes",
    data(){
        return{
            cadastro: {
                Nome: "",
                Descricao: "",
            }
        }
    },
    methods: {
        cadastrarServico(){
            var data = {
                Nome: this.cadastro.Nome,
                Descricao: this.cadastro.Descricao,
            }
            ServicoDataService.cadastrar(data)
                .then(() => {
                    this.$router.push('/servico/listar')
                })
        }
    }
}
</script>

<style>

</style>