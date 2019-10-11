using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Impresion
    {
        private string _nombre_impresora;
        private string _mensaje;
        private string _archivo;

        public string Archivo
        {
            get { return _archivo; }
            set { _archivo = value; }
        }

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public string Nombre_impresora
        {
            get { return _nombre_impresora; }
            set { _nombre_impresora = value; }
        }

        public void NuevaImpresion()
        {
            N_Archivo archivo = new N_Archivo();
            archivo.Borrar(_archivo);
        }

        public void Grabar(string datos)
        {
            N_Archivo archivoTemporal = new N_Archivo();
            archivoTemporal.Nombre_archivo = _archivo;
            archivoTemporal.Grabar(datos);
        }
    }
}
