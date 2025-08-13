using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_AYEDD
{
    public class Producto
    {
        public List<CarritoItem> Items { get; set; } = new List<CarritoItem>();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto(int id, string nombre, string categoria, decimal precio, int stock)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Precio = precio;
            this.Stock = stock;
        }

        public Producto()
        {
            Id = 0;
            Nombre = string.Empty;
            Categoria = string.Empty;
            Precio = 0.0m;
            Stock = 0;
        }
    }
}
