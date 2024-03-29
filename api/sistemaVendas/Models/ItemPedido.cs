using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Dto;

namespace sistemaVendas.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        
        public ItemPedido()
        {
            
        }

        public ItemPedido(CadastrarItemPedidoDTO dto)
        {   
            PedidoId = dto.PedidoId;
            ServicoId = dto.ServicoId;
            Quantidade = dto.Quantidade;
            Valor = dto.Valor;
        }

        public void MapearAtualizarPedidoDTO(AtualizarItemPedidoDTO dto)
        {
            PedidoId = dto.PedidoId;
            ServicoId = dto.ServicoId;
            Quantidade = dto.Quantidade;
            Valor = dto.Valor;
        }
    }
}