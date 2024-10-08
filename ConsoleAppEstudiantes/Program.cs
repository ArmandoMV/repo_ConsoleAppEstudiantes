public class Program
{
    static void Main(string[] args)
    {
        var estudiantes = EstudianteData.ObtenerEstudiantes();

        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre} - Edad: {estudiante.Edad}");
        }
    }
}