using System;
using System.Collections.Generic;
using System.Text.Json;

namespace TP_Integrador_AYEDD
{
    public class Program
    {
        static List<Producto> productos = new List<Producto>();

        static void Main(string[] args)
        {

            ProductosPrecargados();

            foreach (var p in productos)
            {
                Console.WriteLine($"{p.Id} - {p.Nombre} - {p.Categoria} - ${p.Precio} - Stock: {p.Stock}");
            }

            GuardarProductosJSON(productos);
            CargarProductosJSON(productos);

        }

        static void ProductosPrecargados()
        {
            productos.Add(new Producto { Id = 1, Nombre = "Camiseta", Categoria = "Ropa", Precio = 5000, Stock = 10 });
            productos.Add(new Producto { Id = 2, Nombre = "Pantalón", Categoria = "Ropa", Precio = 8000, Stock = 5 });
            productos.Add(new Producto { Id = 3, Nombre = "Gorra", Categoria = "Accesorios", Precio = 3000, Stock = 20 });
        }

        static void GuardarProductosJSON(List<Producto> productos)
        {
            string json = JsonSerializer.Serialize(productos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("productos.json", json);
            Console.WriteLine("Productos guardados en productos.json");
        }

        static void CargarProductosJSON(List<Producto> productos)
        {
            if (File.Exists("productos.json"))
            {
                string json = File.ReadAllText("productos.json");
                productos = JsonSerializer.Deserialize<List<Producto>>(json);
                Console.WriteLine("Productos cargados desde productos.json");
            }
            else
            {
                Console.WriteLine("No existe el archivo productos.json");
            }
        }


    }
}
