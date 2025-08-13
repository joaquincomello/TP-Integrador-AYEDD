using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_AYEDD
{
    public class CarritoItem
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public CarritoItem(Producto producto, int cantidad, decimal precioUnitario)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.PrecioUnitario = precioUnitario;
        }

        public CarritoItem()
        {
            Producto = new Producto();
            Cantidad = 0;
            PrecioUnitario = 0.0m;
        }
    }
}
