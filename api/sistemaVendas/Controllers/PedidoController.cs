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
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _repository;
        public PedidoController(PedidoRepository repository)
        {
            _repository = repository;
        }
        
        [HttpPost]
        public IActionResult Cadastrar(CadastrarPedidoDTO dto)
        {
            var pedido = new Pedido(dto);
            _repository.Cadastrar(pedido);
            return Ok(pedido);
        }

        [HttpGet("listar")]
        public IActionResult ObterTodos()
        {
            var pedidos = _repository.ObterTodos();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var pedido = _repository.ObterPorId(id);
            if(pedido is not null)
            {
                return Ok(pedido);
            }
            return NotFound(new {mensagem = $"Não foi possivel encontrar um pedido com id {id}"});
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPedido(int id, AtualizarPedidoDTO dto)
        {
            var pedido = _repository.ObterPorId(id);
            pedido.MapearAtualizarPedidoDTO(dto);
            if(pedido is not null)
            {
                return Ok(dto);
            }
            return NotFound(new {mensagem = $"Não foi possivel encontrar um pedido com id {id}"});
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPedido(int id)
        {
            var pedido = _repository.ObterPorId(id);
            if(pedido is not null){
                _repository.DeletarPedido(pedido);
                return NoContent();
            }
            return NotFound(new {mensagem = $"No foi possivel encontrar um pedido com id {id}"});
            
        }
    }
}