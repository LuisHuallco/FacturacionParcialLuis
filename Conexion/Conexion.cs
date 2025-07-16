using MySql.Data.MySqlClient;

namespace SistemaFacturacionParcial2.Conexion
{
    public class Conexion
    {
        private string cadena = "server=localhost;database=SistemaFacturacionParcial2;uid=root;pwd=123;";

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
