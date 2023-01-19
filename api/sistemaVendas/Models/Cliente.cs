using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Dto;

namespace sistemaVendas.Models
{
    public class Cliente 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(CadastrarClienteDTO dto)
        {
            Nome = dto.Nome;
            Email = dto.Email;
            Login = dto.Login;
            Senha = dto.Senha;
        }

        public void MapearAtualizarClienteDTO(AtualizarClienteDTO dto)
        {
            Email = dto.Email;
            Nome = dto.Nome;
            Login = dto.Login;
            Senha = dto.Senha;
        }
    }
}