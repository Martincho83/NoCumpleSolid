
namespace NoSolid
{
    public class Tren : ITransporte
    {
        public string Nombre { get; set; }
        public int VelocidadActual { get; set; }
        public int VelocidadMaxima { get; set; }

        public void Mover()
        {
            // Lógica para mover el tren
            Console.WriteLine("El tren se está moviendo.");
        }

        public void Volar(int altitud)
        {
            // El tren no puede volar
            throw new NotImplementedException("El tren no puede volar.");
        }

        public void GuardarEnBD()
        {
            // Lógica para guardar en la base de datos
            Console.WriteLine("Guardando el tren en la base de datos.");
        }
    }
}
