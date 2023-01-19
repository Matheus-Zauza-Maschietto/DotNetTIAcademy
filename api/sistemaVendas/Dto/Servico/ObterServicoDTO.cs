using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Models;

namespace sistemaVendas.Dto
{
    public class ObterServicoDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ObterServicoDTO(Servico servico)
        {
            Nome = servico.Nome;
            Descricao = servico.Descricao;
        }
    }
}