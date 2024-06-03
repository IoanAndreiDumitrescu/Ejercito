using EjercitoConsoleApp;

public class FactoryUnidades
{
    public IUnidad CrearTransporteMX()
    {
        return new Caballeria { Nombre = "Transporte MX-7899", Velocidad = 4.5f, Blindaje = 1.4f, PotenciaFuego = 0, Precio = 4200 };
    }

    public IUnidad CrearTanqueSombras()
    {
        return new Caballeria { Nombre = "Tanque de ataque Sombras-VB98", Velocidad = 7.3f, Blindaje = 4.8f, PotenciaFuego = 9.8f, Precio = 15600 };
    }

    public IUnidad CrearTransporteTaxin()
    {
        return new Caballeria { Nombre = "Transporte rápido TAXIN-66", Velocidad = 12f, Blindaje = 0, PotenciaFuego = 0, Precio = 1600 };
    }

    public IUnidad CrearInfanteriaBasica()
    {
        return new Infanteria { Nombre = "Infanteria Basica", Velocidad = 6f, Blindaje = 0, PotenciaFuego = 7, Precio = 250 };
    }

    public IUnidad CrearAmetrallador()
    {
        return new Infanteria { Nombre = "Ametrallador", Velocidad = 4f, Blindaje = 0, PotenciaFuego = 10, Precio = 400 };
    }

    public IUnidad CrearSanitario()
    {
        return new Infanteria { Nombre = "Sanitario", Velocidad = 7f, Blindaje = 5, PotenciaFuego = 0, Precio = 500 };
    }

    public IUnidad CrearCanonAnAereo()
    {
        return new Artilleria { Nombre = "Cañon An aereo", Velocidad = 1f, Blindaje = 0f, PotenciaFuego = 22f, Precio = 1100 };
    }

    public IUnidad CrearTorpederoMovil()
    {
        return new Artilleria { Nombre = "Torpedero móvil", Velocidad = 3f, Blindaje = 2f, PotenciaFuego = 19f, Precio = 1350 };
    }

    public IUnidad CrearCanon()
    {
        return new Artilleria { Nombre = "Cañon", Velocidad = 0f, Blindaje = 0f, PotenciaFuego = 14f, Precio = 1100 };
    }
}