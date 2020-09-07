using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> ListaProductos = PrimeraCarga();
        }

        /// <summary>
        /// Carga Inicial de Productos
        /// </summary>
        /// <returns>List<Producto></returns>
        public static List<Producto> PrimeraCarga()
        {
            List<Producto> ListaProductos = new List<Producto>
            {
                new Producto { IdProducto = 12, Nombre = "Ladrillo", Categoria = "Construccion", Precio = 80, StockActual = 120, Vendidos = 50 },
                new Producto { IdProducto = 15, Nombre = "Destornillador", Categoria = "Herramienta", Precio = 95, StockActual = 124, Vendidos = 13 },
                new Producto { IdProducto = 4, Nombre = "Bombillas", Categoria = "Electricidad", Precio = 20, StockActual = 300, Vendidos = 100 },
                new Producto { IdProducto = 1, Nombre = "Caños de agua", Categoria = "Plomeria", Precio = 100, StockActual = 0, Vendidos = 500 },
                new Producto { IdProducto = 9, Nombre = "Pinza", Categoria = "Herramientas", Precio = 135, StockActual = 80, Vendidos = 25 },
                new Producto { IdProducto = 10, Nombre = "Flexible caño", Categoria = "Plomeria", Precio = 100, StockActual = 5, Vendidos = 495 },
                new Producto { IdProducto = 11, Nombre = "Canillas", Categoria = "Plomeria", Precio = 45, StockActual = 15, Vendidos = 1200 },
                new Producto { IdProducto = 90, Nombre = "Bolsa Arena", Categoria = "Construccion", Precio = 60, StockActual = 45, Vendidos = 1500 },
                new Producto { IdProducto = 31, Nombre = "Martillo", Categoria = "Herramientas", Precio = 120, StockActual = 150, Vendidos = 95 },
                new Producto { IdProducto = 7, Nombre = "Cable (por metro)", Categoria = "Electricidad", Precio = 50, StockActual = 98, Vendidos = 30}
            };

            return ListaProductos;
        }
    }
}
