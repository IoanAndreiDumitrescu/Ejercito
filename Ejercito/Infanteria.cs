﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoConsoleApp
{
    public class Infanteria : IUnidad
    {
        public string Nombre {  get; set; }
        public float Velocidad { get; set; }
        public float Blindaje { get; set; }
        public float PotenciaFuego { get; set; }
        public float Precio { get; set; }
    }
}
