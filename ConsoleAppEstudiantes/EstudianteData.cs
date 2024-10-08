using Dapper;
using System.Data.SqlClient;

public static class EstudianteData
{
    /// <summary>
    /// Conexión a la BD
    /// </summary>
    private static string connectionString = "Server=.\\SQLExpress;Database=Evaluacion;Trusted_Connection=true;TrustServerCertificate=true";

    /// <summary>
    /// Método para obtener todos los estudiantes 
    /// </summary>
    /// <returns>Devuelve estudiantes</returns>
    public static IEnumerable<Estudiante> ObtenerEstudiantes()
    {
        try
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string stored = "spObtenerEstudiantes";
                return conexion.Query<Estudiante>(stored).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return Enumerable.Empty<Estudiante>();
        }
    }
}