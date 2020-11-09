using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Pedido
    {

        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public double ValorTotal { get; set; }

        public int MyProperty { get; set; }

    }
}
