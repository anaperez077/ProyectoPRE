//Codigo para verificar la conexion de la base de datos
using System.Data.SQLite;
public class Conexion
{
    public static string cadena = "Data Source=LibreriaSJ.db;Version=3;";

    public static SQLiteConnection ObtenerConexion()
    {
        return new SQLiteConnection(cadena);
    }
}