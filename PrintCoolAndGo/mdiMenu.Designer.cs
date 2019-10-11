namespace PrintCoolAndGo
{
    partial class mdiMenu
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
            this.menuStripBarraPrincipal = new System.Windows.Forms.MenuStrip();
            this.etiqueta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiqueta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiqueta3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBarraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripBarraPrincipal
            // 
            this.menuStripBarraPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiqueta1ToolStripMenuItem,
            this.etiqueta2ToolStripMenuItem,
            this.etiqueta3ToolStripMenuItem});
            this.menuStripBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripBarraPrincipal.Name = "menuStripBarraPrincipal";
            this.menuStripBarraPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripBarraPrincipal.TabIndex = 1;
            this.menuStripBarraPrincipal.Text = "menuStrip1";
            // 
            // etiqueta1ToolStripMenuItem
            // 
            this.etiqueta1ToolStripMenuItem.Name = "etiqueta1ToolStripMenuItem";
            this.etiqueta1ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.etiqueta1ToolStripMenuItem.Text = "Etiqueta 1";
            // 
            // etiqueta2ToolStripMenuItem
            // 
            this.etiqueta2ToolStripMenuItem.Name = "etiqueta2ToolStripMenuItem";
            this.etiqueta2ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.etiqueta2ToolStripMenuItem.Text = "Etiqueta 2";
            // 
            // etiqueta3ToolStripMenuItem
            // 
            this.etiqueta3ToolStripMenuItem.Name = "etiqueta3ToolStripMenuItem";
            this.etiqueta3ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.etiqueta3ToolStripMenuItem.Text = "Etiqueta 3";
            // 
            // mdiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripBarraPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripBarraPrincipal;
            this.Name = "mdiMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.mdiMenu_Load);
            this.menuStripBarraPrincipal.ResumeLayout(false);
            this.menuStripBarraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripBarraPrincipal;
        private System.Windows.Forms.ToolStripMenuItem etiqueta1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiqueta2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiqueta3ToolStripMenuItem;
    }
}