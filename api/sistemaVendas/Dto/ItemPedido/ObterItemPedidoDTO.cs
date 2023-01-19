using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Models;

namespace sistemaVendas.Dto
{
    public class ObterItemPedidoDTO
    {
        public Pedido Pedido { get; set; }
        public Servico Servico { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        public ObterItemPedidoDTO(ItemPedido itemPedido)
        {
            Pedido = itemPedido.Pedido;
            Servico = itemPedido.Servico;
            Quantidade = itemPedido.Quantidade;
            Valor = itemPedido.Valor;
        }
    }
}