using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaVendas.Dto
{
    public class AtualizarVendedorDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}