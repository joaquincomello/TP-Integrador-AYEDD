using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_AYEDD
{
    public class Carrito
    {
        public List<CarritoItem> Items { get; set; } = new List<CarritoItem>();
        public Cliente Cliente { get; set; }

        public Carrito(Cliente cliente)
        {
            this.Cliente = cliente;
        }

        public Carrito()
        {
            Cliente = new Cliente();
        }

        public void AgregarProducto(Producto producto, int cantidad)
        {
            Items.Add(new CarritoItem
            {
                Producto = producto,
                Cantidad = cantidad,
                PrecioUnitario = producto.Precio
            });
        }

        public void QuitarProducto(int idProducto)
        {
            Items.RemoveAll(i => i.Producto.Id == idProducto);
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
