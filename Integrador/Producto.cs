using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Producto
    {
        public int IdProducto { set; get; }
        public string Nombre { set; get; }
        public string Categoria { set; get; }
        public int Precio { set; get; }
        public int StockActual { set; get; }
        public int Vendidos { set; get; }
    }
}
