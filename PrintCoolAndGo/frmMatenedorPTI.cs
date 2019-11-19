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
    public partial class frmMatenedorPTI : Form
    {
        public frmMatenedorPTI()
        {
            InitializeComponent();
        }

        N_Etiqueta_PTI etiquetaPTI = new N_Etiqueta_PTI();

        private void frmMatenedorPTI_Load(object sender, EventArgs e)
        {
            CargarLista();

        }

        void CargarLista()
        {
            dgvLista.DataSource = etiquetaPTI.ListaEtiquetas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreEtiqueta.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese nombre Etiqueta");
                return;
            }

            if (txtImportador.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Importador");
                return;
            }

            if (txtProducto.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Producto");
                return;
            }

            if (txtEmbalaje.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Embalaje");
                return;
            }

            if (txtCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Categoria");
                return;
            }

            if (txtGTIN.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese GTIN");
                return;
            }

            E_Etiqueta_PTI etiqueta = new E_Etiqueta_PTI();

            etiqueta.Nombre_etiqueta = txtNombreEtiqueta.Text;
            etiqueta.Importador = txtImportador.Text;
            etiqueta.Producto = txtProducto.Text;
            etiqueta.Embalaje = txtEmbalaje.Text;
            etiqueta.Categoria = txtCategoria.Text;
            etiqueta.Gtin = txtGTIN.Text;

            etiquetaPTI.CrearEtiqueta(etiqueta);

            CargarLista();
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txtCategoria.Text = "";
            txtEmbalaje.Text = "";
            txtImportador.Text = "";
            txtNombreEtiqueta.Text = "";
            txtProducto.Text = "";

            txtNombreEtiqueta.Focus();

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
