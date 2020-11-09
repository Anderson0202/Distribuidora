﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Cliente
    {

        public string Direccion { get; set; }
        public string  TipoCliente { get; set; }
        public string Email { get; set; }

        public Cliente()
        {

        }

        public Cliente(string direccion, string tipoCliente, string email)
        {
            Direccion = direccion;
            TipoCliente = tipoCliente;
            Email = email;
        }
    }
}
