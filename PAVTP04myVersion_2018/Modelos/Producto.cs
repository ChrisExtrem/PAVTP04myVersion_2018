using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAVTP04myVersion_2018.Modelos
{
    class Producto
    {
        public Producto()
        {
            Estado = Estado.Activo;
        }

        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBruto { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PrecioNeto => PrecioBruto * (1 + PorcentajeIva);
        public Estado Estado { get; set; }
        public int Existencias { get; set; }
    }
}
