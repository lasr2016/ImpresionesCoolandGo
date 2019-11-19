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
    public partial class frmMantenedorProductor : Form
    {
        public frmMantenedorProductor()
        {
            InitializeComponent();
        }

        N_Etiqueta_Productor_Packing etiquetaProductor = new N_Etiqueta_Productor_Packing();

        private void frmMantenedorProductor_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        void CargarLista()
        {
            dgvLista.DataSource = etiquetaProductor.ListaEtiquetas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreEtiqueta.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese nombre Etiqueta");
                return;
            }

            if (txtCSG.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese CSG");
                return;
            }

            if (txtRegionCSG.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Region");
                return;
            }

            if (txtProvinceCSG.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Province");
                return;
            }

            if (txtTownshipCSG.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Township");
                return;
            }

            if (txtCSP.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese CSP");
                return;
            }

            if (txtRegionCSP.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Region");
                return;
            }

            if (txtProvinceCSP.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese Province");
                return;
            }

            if (txtTownshipCSP.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Township");
                return;
            }

            E_Etiqueta_Productor_Packing etiqueta = new E_Etiqueta_Productor_Packing();

            etiqueta.Nombre_etiqueta = txtNombreEtiqueta.Text;
            etiqueta.CSG =  txtCSG.Text;
            etiqueta.Region_CSG = txtRegionCSG.Text;
            etiqueta.Province_CSG = txtProvinceCSG.Text;
            etiqueta.Township_CSG= txtTownshipCSG.Text;
            etiqueta.CSP = txtCSP.Text;
            etiqueta.Region_CSP = txtRegionCSP.Text;
            etiqueta.Province_CSP = txtProvinceCSP.Text;
            etiqueta.Township_CSP = txtTownshipCSP.Text;
            etiqueta.Producto = txtProducto.Text;
            etiqueta.Embalaje = txtEmbalaje.Text;
            etiqueta.OnlyExport = txtforExport.Text;
            etiqueta.Exported_by = txtExportedBy.Text;



            etiquetaProductor.CrearEtiqueta(etiqueta);

            CargarLista();
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txtNombreEtiqueta.Text = "";
            txtCSG.Text = "";
            txtRegionCSG.Text = "";
            txtProvinceCSG.Text = "";
            txtTownshipCSG.Text = "";
            txtCSP.Text = "";
            txtRegionCSP.Text = "";
            txtProvinceCSP.Text = "";
            txtTownshipCSP.Text = "";
            txtProducto.Text = "";
            txtEmbalaje.Text = "";
            txtforExport.Text = "";
            txtExportedBy.Text = "";            

            txtNombreEtiqueta.Focus();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
