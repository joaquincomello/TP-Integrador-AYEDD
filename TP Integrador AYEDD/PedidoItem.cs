using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_AYEDD
{
    public class PedidoItem
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public PedidoItem(int productoId, int cantidad, decimal precioUnitario)
        {
            this.ProductoId = productoId;
            this.Cantidad = cantidad;
            this.PrecioUnitario = precioUnitario;
        }

        public PedidoItem()
        {
            ProductoId = 0;
            Cantidad = 0;
            PrecioUnitario = 0.0m;
        }
    }
}
