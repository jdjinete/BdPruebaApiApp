﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdPruebaApiApp.DTO
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string SKU { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }

    }
}