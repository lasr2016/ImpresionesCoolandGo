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
    public partial class frmMantenedorQuesos : Form
    {
        public frmMantenedorQuesos()
        {
            InitializeComponent();
        }

        N_Etiqueta_Quesos etiquetaQuesos = new N_Etiqueta_Quesos();

        private void frmMantenedorQuesos_Load(object sender, EventArgs e)
        {

            CargarLista();
        }

        void CargarLista()
        {
            dgvLista.DataSource = etiquetaQuesos.ListaEtiquetas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreEtiqueta.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese nombre Etiqueta");
                return;
            }

           
            if (txtProducto.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Producto");
                return;
            }

            if (txtCodigoBarras.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Codigo Barras");
                return;
            }

            if (txtCodigoSAP.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Sap");
                return;
            }
           

            E_Etiqueta_Quesos etiqueta = new E_Etiqueta_Quesos();

            etiqueta.Nombre_etiqueta = txtNombreEtiqueta.Text;
            etiqueta.Descripcion = txtProducto.Text;
            etiqueta.CodigoBarras = txtCodigoBarras.Text;
            etiqueta.SAP = txtCodigoSAP.Text;
          
            etiquetaQuesos.CrearEtiqueta(etiqueta);

            CargarLista();
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txtNombreEtiqueta.Text = "";
            txtProducto.Text = "";
            txtCodigoBarras.Text = "";
            txtCodigoSAP.Text = "";
            
            txtNombreEtiqueta.Focus();

        }
    }
}
