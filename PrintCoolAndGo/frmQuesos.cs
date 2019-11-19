using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace PrintCoolAndGo
{
    public partial class frmQuesos : Form
    {
        public frmQuesos()
        {
            InitializeComponent();
        }

        N_Etiqueta_Quesos etiqueta = new N_Etiqueta_Quesos();

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void frmQuesos_Load(object sender, EventArgs e)
        {
            cmbEtiqueta.DataSource = etiqueta.ListaEtiquetas();
            cmbEtiqueta.DisplayMember = "nombre_etiqueta";
            cmbEtiqueta.ValueMember = "ID";

            cmbEtiqueta.SelectedIndex = -1;
        }
    }
}
