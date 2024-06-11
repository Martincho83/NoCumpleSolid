// See https://aka.ms/new-console-template for more information

using NoSolid;

class Program
{
    static void Main(string[] args)
    {
        List<ITransporte> transportes = new List<ITransporte>();

        Avion avion1 = new Avion
        {
            Nombre = "AVION 01",
            VelocidadActual = 0,
            VelocidadMaxima = 100,
            AlturaActual = 0,
            AlturaMaxima = 100
        };
        transportes.Add(avion1);

        Tren tren1 = new Tren
        {
            Nombre = "TREN 01",
            VelocidadActual = 0,
            VelocidadMaxima = 100
        };
        transportes.Add(tren1);

        foreach (var transporte in transportes)
        {
            TransporteService servicio = new TransporteService(transporte);
            servicio.MoverTransporte();
            servicio.GuardarTransporte();

            if (transporte is Avion)
            {
                transporte.Volar(100);
            }
        }

        Console.WriteLine("Fin del viaje :)");
    }
}