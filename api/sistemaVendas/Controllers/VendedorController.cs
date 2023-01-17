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
    public class VendedorController : ControllerBase
    {
        private readonly VendedorRepository _repository;
        public VendedorController(VendedorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarVendedorDTO dto)
        {
            var vendedor = new Vendedor(dto);
            _repository.Cadastrar(vendedor);
            return Ok(vendedor);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendedor = _repository.ObterPorId(id);
            if(vendedor is not null)
            {
                var vendedorDTO = new ObterVendedorDTO(vendedor);
                return Ok(vendedor);
            }
                
            else
                return NotFound(new { Mensagem = "Vendedor não encontrado"});
        }

        [HttpGet("obterpornome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var vendedores = _repository.ObterPorNome(nome);
            if(vendedores.Count == 0){
                return NotFound(new { Mensagem = $"Não foi encontrado nenhum item com o nome: {nome}"});
            }
            return Ok(vendedores);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarVendedorDTO dto)
        {
            var vendedor = _repository.ObterPorId(id);
            if(vendedor is not null)
            {
                vendedor.MapearAtualizarVendedorDTO(dto);
                _repository.AtualizarVendedor(vendedor);
                return Ok(vendedor);
            }
            return NotFound(new {mensagem = "Não foi possivel atualizar o vendedor"});
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var vendedor = _repository.ObterPorId(id);

            if(vendedor is not null)
            {
                _repository.DeletarVendedor(vendedor);
                return NoContent();
            }
            return NotFound(new {mensagem = "Não foi encontrado nenhum vendedor com esse id para ser excluido"});
        }

    }
}