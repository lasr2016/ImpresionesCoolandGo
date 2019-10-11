using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Archivo
    {
        private string _archivo;

        public string Nombre_archivo
        {
            get { return _archivo; }
            set { _archivo = value; }
        }

        public void Grabar(string datos)
        {
            CheckDir(_archivo);
            StreamWriter writer = new StreamWriter(_archivo, true);
            writer.WriteLine(datos);
            writer.Close();
        }

        public void Borrar(string archivo)
        {
            try
            {
                File.Delete(archivo);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
        public void CheckDir(string dir)
        {
            try
            {
                char backslash = @"\".ToCharArray()[0];
                int last = dir.LastIndexOf(backslash);
                string tempdir = (dir.Substring(0, last));
                Directory.CreateDirectory(tempdir);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
