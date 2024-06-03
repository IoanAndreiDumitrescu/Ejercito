using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoConsoleApp
{
    public class Artilleria : IUnidad
    {
        public float Velocidad { get; set; }
        public float Blindaje { get; set; }
        public float PotenciaFuego { get; set; }
        public float Precio { get; set; }
        public string Nombre { get ; set; }
    }
}
