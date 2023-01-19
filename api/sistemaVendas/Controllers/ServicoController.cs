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
    public class ServicoController: ControllerBase
    {
        private readonly ServicoRepository _repository;
        public ServicoController(ServicoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarServicoDTO dto)
        {
            var servico = new Servico(dto);
            _repository.Cadastrar(servico);
            return Ok(servico);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var servico = _repository.ObterPorId(id);
            if(servico is not null)
            {   
                var servicoDTO = new ObterServicoDTO(servico);
                return Ok(servicoDTO);
            }
            return NotFound(new {mensagem = $"Não foi encontrada um serviço com id {id}"}); 
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var servicos = _repository.ObterTodos();
            return Ok(servicos);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarServico(int id, AtualizarServicoDTO dto)
        {
            var servico = _repository.ObterPorId(id);
            if(servico is not null)
            {
                servico.MapearAtualizarServicoDTO(dto);
                _repository.AtualizarServico(servico);
                return Ok(dto);
            }
           return NotFound(new {menssagem = $"Não foi possivel encontrar o servico de id {id}"});
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarServico(int id)
        {
            var servico = _repository.ObterPorId(id);
            if(servico is not null)
            {
                _repository.DeletarServico(servico);
                return Ok(servico);
            }
           return NotFound(new {menssagem = $"Não foi possivel encontrar o servico de id {id}"});
        }
    }
}