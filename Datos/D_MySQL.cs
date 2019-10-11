using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_MySQL
    {
        static string _StringConexion = "";
        public static string StringConexion
        {
            get => _StringConexion;  //Lee desde Variable sArchivo
            set => _StringConexion = value;  //escribe a variable sArchivo
        }

        protected MySqlConnection MySQLConexion;

        public bool Conectar()
        {
            string ConexionMysql;
            bool estado = false;
            if (StringConexion.Trim() == "")
            {
                //ConexionMysql = "server = pcl-pc; user id = atc; password = 123atc; port = 3306; database = Impresion_FCC";
                ConexionMysql = "server = localhost; user id = admin; password = 57706897; port = 3306; database = Impresion_CAG";
            }
            else
            {
                ConexionMysql = StringConexion;
            }
            try
            {
                MySQLConexion = new MySqlConnection();
                //MySQLConexion.ConnectionString = StringConexion;
                MySQLConexion.ConnectionString = ConexionMysql;
                MySQLConexion.Open();
                estado = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return estado;
        }

        public void Desconectar()
        {
            MySQLConexion.Close();
        }
    }
}
