using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Models;

namespace sistemaVendas.Dto
{
    public class ObterClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }

        public ObterClienteDTO(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Email = cliente.Email;
            Login = cliente.Login;
        }
    }
}