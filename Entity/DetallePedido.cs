using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class DetallePedido
    {

        public int IdDetallePedido { get; set; }
        public double TotalNeto { get; set; }
        public double TotalDescuento { get; set; }
        public double TotalPagar { get; set; }

    }
}
