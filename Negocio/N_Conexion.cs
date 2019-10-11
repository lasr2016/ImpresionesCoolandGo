using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Conexion
    {
        public static void setConnectionString(string _connectionString)
        {
            Datos.D_MySQL.StringConexion = _connectionString;
        }
    }
}
