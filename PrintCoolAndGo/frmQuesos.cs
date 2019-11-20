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
using Entidades;



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
            N_CodigoZPL impresion = new N_CodigoZPL();
            E_Etiqueta_Quesos etiquetaQueso;

            string ID = cmbEtiqueta.SelectedValue.ToString();

            etiquetaQueso =  etiqueta.ObtenerEtiqueta(ID);

            impresion.ImpresionEtiquetaQuesos(etiquetaQueso.Descripcion, etiquetaQueso.CodigoBarras, dateTimePicker1.Text, etiquetaQueso.SAP, txtCantidad.Text);
            
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
