using System;

public class Avion : ITransporte
{
    public string Nombre { get; set; }
    public int VelocidadActual { get; set; }
    public int VelocidadMaxima { get; set; }
    public int AlturaActual { get; set; }
    public int AlturaMaxima { get; set; }

    public void Mover()
    {
        // Lógica para mover el avión
        Console.WriteLine("El avión se está moviendo.");
    }

    public void Volar(int altitud)
    {
        // Lógica para volar
        Console.WriteLine($"El avión está volando a una altura de {altitud} metros.");
    }

    public void GuardarEnBD()
    {
        // Lógica para guardar en la base de datos
        Console.WriteLine("Guardando el avión en la base de datos.");
    }
}
