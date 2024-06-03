using EjercitoConsoleApp;

public static class Program
{
    public static void Main(string[] args)
    {
        Ejercito MiEjercito = new Ejercito();
        var factory = new FactoryUnidades();
    IUnidad[] unidades =
    {
        factory.CrearTransporteMX(),
        factory.CrearTanqueSombras(),
        factory.CrearTransporteTaxin(),
        factory.CrearInfanteriaBasica(),
        factory.CrearAmetrallador(),
        factory.CrearSanitario(),
        factory.CrearCanonAnAereo(),
        factory.CrearTorpederoMovil(),
        factory.CrearCanon()
    };

        foreach (var unidad in unidades)
        {
            MiEjercito.AgregarUnidad(unidad);

            Console.WriteLine("\nDetalles unidad:");
            Console.WriteLine($"Nombre: {unidad.Nombre}");
            Console.WriteLine($"Velocidad: {unidad.Velocidad}");
            Console.WriteLine($"Blindaje: {unidad.Blindaje}");
            Console.WriteLine($"Potencia de fuego: {unidad.PotenciaFuego}");
            Console.WriteLine($"Precio: {unidad.Precio}");
        }

        MiEjercito.MostrarDetalles();
    }
}