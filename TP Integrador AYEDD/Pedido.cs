using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_AYEDD
{
    public class Pedido
    {
        public List<PedidoItem> Items { get; set; } = new List<PedidoItem>();
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Estado { get; set; } = "Creado";

        public Pedido(int id, Cliente cliente)
        {
            this.Id = id;
            this.Cliente = cliente;
        }

        public Pedido()
        {
            Id = 0;
            Cliente = new Cliente();
            Estado = "Creado";
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Cantidad * item.PrecioUnitario;
            }
            return total;
        }
    }
}
