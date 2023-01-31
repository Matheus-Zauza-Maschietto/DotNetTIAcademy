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
    public class ItemPedidoController: ControllerBase
    {
        private readonly ItemPedidoRepository _repository;
        public ItemPedidoController(ItemPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarItemPedidoDTO dto)
        {
            var ItemPedido = new ItemPedido(dto);
            _repository.Cadastrar(ItemPedido);
            return Ok(ItemPedido);
        }

        [HttpGet("listar")]
        public IActionResult ObterTodos()
        {
            var ItensPedido = _repository.ObterTodos();
            return Ok(ItensPedido);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var ItemPedido = _repository.ObterPorId(id);
            if(ItemPedido is not null)
            {
                var ItemPedidoDTO = new ObterItemPedidoDTO(ItemPedido);
                return Ok(ItemPedido);
            }
            return NotFound(new {mensagem = $"Não foi encontrado nenhum item de pedido com id {id}"});
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarItemPedido(int id, AtualizarItemPedidoDTO dto)
        {
            var itemPedido = _repository.ObterPorId(id);
            if(itemPedido is not null)
            {
                itemPedido.MapearAtualizarPedidoDTO(dto);
                return Ok(itemPedido);
            }
            return NotFound(new {mensagem = $"Não foi possivel encontrar nenhum item de pedido com id {id}"});
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarItemPedido(int id)
        {
            var itemPedido = _repository.ObterPorId(id);
            if(itemPedido is not null)
            {
                _repository.Deletar(itemPedido);
                return NoContent();
            }
            return NotFound(new {mensagem = $"Não foi possivel encontrar nenhum item de pedido com id {id}"});
        }
    }
}