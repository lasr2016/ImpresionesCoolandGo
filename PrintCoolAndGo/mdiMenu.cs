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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmPti frmobj = new frmPti
            {
                MdiParent = this
            };
            frmobj.Show();
            

        }

        private void etiqueta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmProductor frmobj = new frmProductor
            {
                MdiParent = this
            };
            frmobj.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frmQuesos frmobj = new frmQuesos
            {
                MdiParent = this
            };
            frmobj.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mantenedorEtiquetaPTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatenedorPTI frmObj = new frmMatenedorPTI();
            frmObj.ShowDialog();

        }

        private void mantenedorEtiquetaQuesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorQuesos frmObj = new frmMantenedorQuesos();
            frmObj.ShowDialog();
        }

        private void mantenedorEtiquetaProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorProductor frmObj = new frmMantenedorProductor();
            frmObj.ShowDialog();
        }
    }
}
