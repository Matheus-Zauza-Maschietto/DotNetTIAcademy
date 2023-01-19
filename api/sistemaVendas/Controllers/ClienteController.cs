using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistemaVendas.Repository;
using sistemaVendas.Dto;
using sistemaVendas.Models;

namespace sistemaVendas.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;
        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarClienteDTO dto)
        {
            var cliente = new Cliente(dto);
            _repository.Cadastrar(cliente);
            return Ok(cliente);
        }

        
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var cliente = _repository.ObterPorId(id);
            if(cliente is not null)
            {
                var clienteDTO = new ObterClienteDTO(cliente);
                return Ok(clienteDTO);
            }
            return NotFound(new {mensagem = $"Não foi encontrado nenhum cliente com o id {id}"});
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarClienteDTO clienteDTO)
        {
            var cliente = _repository.ObterPorId(id);
            if(cliente is not null)
            {
                cliente.MapearAtualizarClienteDTO(clienteDTO);
                _repository.AtualizarCliente(cliente);
                return Ok(cliente);
            }
            return NotFound(new {mensagem= $"Não foi encontrado nenhum cliente com o id {id}"});
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var cliente = _repository.ObterPorId(id);
            if(cliente is not null)
            {   
                _repository.DeletarCliente(cliente);
                return NoContent();
            }
            return NotFound(new {mensagem= $"Não foi encontrado nenhum cliente com o id {id}"});
        }
    }
}