using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintCoolAndGo
{
    public partial class mdiMenu : Form
    {
        public mdiMenu()
        {
            InitializeComponent();
        }

        private void mdiMenu_Load(object sender, EventArgs e)
        {
            N_Conexion.setConnectionString(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);
            NameValueCollection settings = ConfigurationManager.GetSection("CoordenadasGroup/Coordenada") as NameValueCollection;

            if (settings != null)
            {
                foreach (string key in settings.AllKeys)
                {
                    Console.Write(key + ": " + settings[key]);
                    if (key.ToLower().Equals("x"))
                    {
                        N_CodigoZPL.axisX = Convert.ToInt32(settings[key]);
                    }
                    else
                    {
                        N_CodigoZPL.axisY = Convert.ToInt32(settings[key]);
                    }
                }
            }
        }
    }
}
