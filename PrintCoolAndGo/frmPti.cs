using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impresora;
using Negocio;
using Entidades;

namespace PrintCoolAndGo
{
    public partial class frmPti : Form
    {
        public frmPti()
        {
            InitializeComponent();
        }

        N_Etiqueta_PTI etiqueta = new N_Etiqueta_PTI();


        private void button1_Click(object sender, EventArgs e)
        {

            if(cmbEtiqueta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Etiqueta");
                return;
            }

            if(txtLote.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Lote");
                return;
            }

            int i;
            string ID_etiqueta = cmbEtiqueta.SelectedValue.ToString();

            E_Etiqueta_PTI etiqueta1 = etiqueta.ObtenerEtiqueta(ID_etiqueta);
           // string sLoteaux;
            string sFecha = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");
            EtiquetaZPL ImpresionEtiqueta = new EtiquetaZPL();


            ImpresionEtiqueta.Impresora = "Etiquetas"; //nombre de la impresora
            ImpresionEtiqueta.Archivo = @"C:\Temp\Impresion.txt";// Ruta del archivo zpl
            ImpresionEtiqueta.NuevaImpresion();   //borra el archivo zpl para nueva impresion


            for (i = 1; i <= Convert.ToInt32(txtCantidad.Text); i++)
            {
               // sLoteaux = lLoteaux.ToString().PadLeft(txtLote.Text.Trim.Length, "0");

                ImpresionEtiqueta.EtiquetaExportacion(etiqueta1.Producto, etiqueta1.Embalaje, etiqueta1.Categoria, etiqueta1.Importador, etiqueta1.Gtin,
                                 txtLote.Text, sFecha, "1", true);

                //ImpresionEtiqueta.EtiquetaExportacion(sDescripcion, sEmbalaje, sCategoria, sImportador, sGTIN,
                //                sLoteaux, sFecha, sCopias, FechaEmpaque);
                //lLoteaux++;

            }

            try
            {
                ImpresionEtiqueta.Imprimir();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.DoEvents();
        }

        private void frmPti_Load(object sender, EventArgs e)
        {
            cmbEtiqueta.DataSource = etiqueta.ListaEtiquetas();
            cmbEtiqueta.DisplayMember = "nombre_etiqueta";
            cmbEtiqueta.ValueMember = "ID";

            cmbEtiqueta.SelectedIndex = -1;

        }
    }
}
