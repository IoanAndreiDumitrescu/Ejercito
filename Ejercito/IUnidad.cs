using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitoConsoleApp
{
    public interface IUnidad
    {
       public string Nombre { get; set; }
      public  float Velocidad { get; }
       public float Blindaje { get; }
      public  float PotenciaFuego { get; }
      public  float Precio { get; }
    }


}
