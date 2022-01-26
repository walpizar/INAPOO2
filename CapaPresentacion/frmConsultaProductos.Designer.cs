namespace CapaPresentacion
{
    partial class frmConsultaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProductos));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlEquinaDerecha = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstvLista = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusquesa = new System.Windows.Forms.Label();
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
            this.pnlTitulo.Size = new System.Drawing.Size(1191, 50);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pnlEquinaDerecha
            // 
            this.pnlEquinaDerecha.Controls.Add(this.pbxCerrar);
            this.pnlEquinaDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEquinaDerecha.Location = new System.Drawing.Point(992, 0);
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
            // lstvLista
            // 
            this.lstvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.ColCodigo,
            this.colNombre,
            this.colPrecio,
            this.colPrecioVenta});
            this.lstvLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvLista.FullRowSelect = true;
            this.lstvLista.GridLines = true;
            this.lstvLista.HideSelection = false;
            this.lstvLista.Location = new System.Drawing.Point(12, 122);
            this.lstvLista.Name = "lstvLista";
            this.lstvLista.Size = new System.Drawing.Size(1167, 584);
            this.lstvLista.TabIndex = 1;
            this.lstvLista.UseCompatibleStateImageBehavior = false;
            this.lstvLista.View = System.Windows.Forms.View.Details;
            this.lstvLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvLista_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 100;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Text = "Código";
            this.ColCodigo.Width = 100;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 250;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "Precio Costo";
            this.colPrecio.Width = 100;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.Text = "Precio Venta";
            this.colPrecioVenta.Width = 100;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Navy;
            this.btnNuevo.Location = new System.Drawing.Point(1042, 64);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(137, 52);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(73, 78);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(536, 26);
            this.txtBusqueda.TabIndex = 3;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBusquesa
            // 
            this.lblBusquesa.AutoSize = true;
            this.lblBusquesa.Location = new System.Drawing.Point(12, 86);
            this.lblBusquesa.Name = "lblBusquesa";
            this.lblBusquesa.Size = new System.Drawing.Size(58, 13);
            this.lblBusquesa.TabIndex = 4;
            this.lblBusquesa.Text = "Búsqueda:";
            // 
            // frmConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 722);
            this.Controls.Add(this.lblBusquesa);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstvLista);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento: Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlEquinaDerecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlEquinaDerecha;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.ListView lstvLista;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader ColCodigo;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ColumnHeader colPrecioVenta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusquesa;
    }
}