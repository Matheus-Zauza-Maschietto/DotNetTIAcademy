<template>
  <div id="cadastro-servico">
    <h3>Atualiazar Serviço</h3>
    <div class="form" style="padding: 1%;">
        <div>
            <label for="" class="form-label">Id</label>
            <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
        </div>
        <div>
            <label for="" class="form-label">Nome</label>
            <input type="text" class="form-control" required placeholder="Nome" v-model="Servico.nome">
        </div>
        <div>
            <label for="" class="form-label">Descrição</label>
            <textarea name="" id="" cols="40" rows="10" required placeholder="Descricao" v-model="Servico.descricao" class="form-control"></textarea>
        </div>

        <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarServico">Cadastrar</button>
    </div>
  </div>
</template>

<script>
import ServicoDataService from '../../services/ServicoDataService.js';

export default {
    name: "ServicoCadastro",
    data(){
        return{
            Servico: {
            },
            updateServico: {
                nome: "",
                descricao: "",
            }
        }
    },
    methods: {
        atualizarServicoData(){
            this.updateServico.nome = this.Servico.nome
            this.updateServico.descricao = this.Servico.descricao
        },
        obterServicos(id){
            ServicoDataService.obterPorId(id)
                .then((response) => {
                    this.Servico = response.data;
                })
        },
        atualizarServico(){
            this.atualizarServicoData()
            ServicoDataService.atualizar(this.$route.params.id, this.updateServico)
                .then(() => {
                    this.$router.push('/servico/listar')
                })
        },

        
        
    },
    mounted(){
        this.obterServicos(this.$route.params.id)
    }
}
</script>

<style>

</style>