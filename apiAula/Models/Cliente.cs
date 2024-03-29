using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAula.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}