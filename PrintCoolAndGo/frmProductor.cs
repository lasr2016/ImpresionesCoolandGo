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
    public partial class frmProductor : Form
    {
        public frmProductor()
        {
            InitializeComponent();
        }

        N_Etiqueta_Productor_Packing etiqueta = new N_Etiqueta_Productor_Packing();

        private void frmProductor_Load(object sender, EventArgs e)
        {
            cmbEtiqueta.DataSource = etiqueta.ListaEtiquetas();
            cmbEtiqueta.DisplayMember = "nombre_etiqueta";
            cmbEtiqueta.ValueMember = "ID";

            cmbEtiqueta.SelectedIndex = -1;
        }
    }
}
