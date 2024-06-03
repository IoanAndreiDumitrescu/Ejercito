using System;
using System.Collections.Generic;
using System.Linq;
using EjercitoConsoleApp;

    public class Ejercito
    {
        private List<IUnidad> unidades = new List<IUnidad>();

        public void AgregarUnidad(IUnidad unidad)
        {
            unidades.Add(unidad);
        }
        
        public float FuegoTotal()
        {
            return unidades.Sum(unidad => unidad.PotenciaFuego);
        }

        public float BlindajeTotal()
        {
            return unidades.Sum(unidad => unidad.Blindaje);
        }

        public float MovimientoTotal()
        {
            return unidades.Sum(unidad => unidad.Velocidad);
        }

        public float CosteTotal()
        {
            return unidades.Sum(unidad => unidad.Precio);
        }

        public string CapacidadMilitar()
        {
            float potenciaFuego = FuegoTotal();
            float movimiento = MovimientoTotal();
            float blindaje = BlindajeTotal();

            float resultado = ((potenciaFuego * movimiento) / 2) / (100 - blindaje);

            return string.Format("{0:0.00}", resultado);
        }

    public void MostrarDetalles()
    {
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine($"\nDetalles del Ejercito:");
        Console.WriteLine($"Total de Unidades: {unidades.Count}");  
        Console.WriteLine($"Fuego Total: {FuegoTotal()}");
        Console.WriteLine($"Blindaje Total: {BlindajeTotal()}");
        Console.WriteLine($"Movimiento Total: {MovimientoTotal()}");
        Console.WriteLine($"Coste Total: {CosteTotal()}");
        Console.WriteLine($"Capacidad Militar: {CapacidadMilitar()}");
    }
}
