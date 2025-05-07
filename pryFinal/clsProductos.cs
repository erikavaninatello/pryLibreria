using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFinal
{
    public class clsProductos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }

        public int Vendido { get; set; }
    }
}
