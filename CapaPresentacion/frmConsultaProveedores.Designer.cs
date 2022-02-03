namespace CapaPresentacion
{
    partial class frmConsultaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProveedores));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlEquinaDerecha = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBusquesa = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lstvLista = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTitulo.SuspendLayout();
            this.pnlEquinaDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Teal;
            this.pnlTitulo.Controls.Add(this.pnlEquinaDerecha);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(748, 50);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlEquinaDerecha
            // 
            this.pnlEquinaDerecha.Controls.Add(this.pbxCerrar);
            this.pnlEquinaDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEquinaDerecha.Location = new System.Drawing.Point(549, 0);
            this.pnlEquinaDerecha.Name = "pnlEquinaDerecha";
            this.pnlEquinaDerecha.Size = new System.Drawing.Size(199, 50);
            this.pnlEquinaDerecha.TabIndex = 2;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbxCerrar.Image")));
            this.pbxCerrar.Location = new System.Drawing.Point(151, 6);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(36, 39);
            this.pbxCerrar.TabIndex = 0;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(26, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // lblBusquesa
            // 
            this.lblBusquesa.AutoSize = true;
            this.lblBusquesa.Location = new System.Drawing.Point(7, 76);
            this.lblBusquesa.Name = "lblBusquesa";
            this.lblBusquesa.Size = new System.Drawing.Size(58, 13);
            this.lblBusquesa.TabIndex = 6;
            this.lblBusquesa.Text = "Búsqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(68, 68);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(536, 26);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lstvLista
            // 
            this.lstvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colApellido1,
            this.colApellido2});
            this.lstvLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvLista.FullRowSelect = true;
            this.lstvLista.GridLines = true;
            this.lstvLista.HideSelection = false;
            this.lstvLista.Location = new System.Drawing.Point(12, 111);
            this.lstvLista.Name = "lstvLista";
            this.lstvLista.Size = new System.Drawing.Size(722, 383);
            this.lstvLista.TabIndex = 7;
            this.lstvLista.UseCompatibleStateImageBehavior = false;
            this.lstvLista.View = System.Windows.Forms.View.Details;
          
            this.lstvLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvLista_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 100;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 150;
            // 
            // colApellido1
            // 
            this.colApellido1.Text = "Primer Apellido";
            this.colApellido1.Width = 150;
            // 
            // colApellido2
            // 
            this.colApellido2.Text = "Segundo Apellido";
            this.colApellido2.Width = 150;
            // 
            // frmConsultaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 550);
            this.Controls.Add(this.lstvLista);
            this.Controls.Add(this.lblBusquesa);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaProveedores";
            this.Load += new System.EventHandler(this.frmConsultaProveedores_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlEquinaDerecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlEquinaDerecha;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBusquesa;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ListView lstvLista;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido1;
        private System.Windows.Forms.ColumnHeader colApellido2;
    }
}