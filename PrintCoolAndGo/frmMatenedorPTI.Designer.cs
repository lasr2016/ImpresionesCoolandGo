namespace PrintCoolAndGo
{
    partial class frmMatenedorPTI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEtiqueta = new System.Windows.Forms.TextBox();
            this.txtImportador = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtEmbalaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtGTIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(15, 176);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(541, 229);
            this.dgvLista.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(454, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 27);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Etiqueta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto";
            // 
            // txtNombreEtiqueta
            // 
            this.txtNombreEtiqueta.Location = new System.Drawing.Point(114, 12);
            this.txtNombreEtiqueta.Name = "txtNombreEtiqueta";
            this.txtNombreEtiqueta.Size = new System.Drawing.Size(163, 20);
            this.txtNombreEtiqueta.TabIndex = 5;
            // 
            // txtImportador
            // 
            this.txtImportador.Location = new System.Drawing.Point(114, 40);
            this.txtImportador.Name = "txtImportador";
            this.txtImportador.Size = new System.Drawing.Size(163, 20);
            this.txtImportador.TabIndex = 6;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(114, 68);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(163, 20);
            this.txtProducto.TabIndex = 7;
            // 
            // txtEmbalaje
            // 
            this.txtEmbalaje.Location = new System.Drawing.Point(114, 96);
            this.txtEmbalaje.Name = "txtEmbalaje";
            this.txtEmbalaje.Size = new System.Drawing.Size(163, 20);
            this.txtEmbalaje.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Embalaje";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(114, 124);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(163, 20);
            this.txtCategoria.TabIndex = 11;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 27);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(454, 57);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 27);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtGTIN
            // 
            this.txtGTIN.Location = new System.Drawing.Point(114, 150);
            this.txtGTIN.Name = "txtGTIN";
            this.txtGTIN.Size = new System.Drawing.Size(163, 20);
            this.txtGTIN.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "GTIN";
            // 
            // frmMatenedorPTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 421);
            this.Controls.Add(this.txtGTIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmbalaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtImportador);
            this.Controls.Add(this.txtNombreEtiqueta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmMatenedorPTI";
            this.Text = "frmMatenedorPTI";
            this.Load += new System.EventHandler(this.frmMatenedorPTI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEtiqueta;
        private System.Windows.Forms.TextBox txtImportador;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtEmbalaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtGTIN;
        private System.Windows.Forms.Label label6;
    }
}