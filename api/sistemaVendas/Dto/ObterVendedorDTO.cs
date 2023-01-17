using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Models;

namespace sistemaVendas.Dto
{
    public class ObterVendedorDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public ObterVendedorDTO(Vendedor vendedor)
        {
            Nome = vendedor.Nome;
            Email = vendedor.Email;
            Telefone = vendedor.Telefone;
            Cpf = vendedor.Cpf;
            Login = vendedor.Login;
        }
    }
}