namespace Sistema_de_Registro_de_Producto_Bodegas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraLateral = new System.Windows.Forms.Panel();
            this.TituloSistema = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listProductos = new System.Windows.Forms.Panel();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.buttonBienvenida = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barraLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.listProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraLateral.Controls.Add(this.buttonCerrar);
            this.barraLateral.Controls.Add(this.buttonBienvenida);
            this.barraLateral.Controls.Add(this.buttonBuscarProducto);
            this.barraLateral.Controls.Add(this.buttonReportes);
            this.barraLateral.Controls.Add(this.buttonInicio);
            this.barraLateral.Location = new System.Drawing.Point(16, 62);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(203, 536);
            this.barraLateral.TabIndex = 0;
            // 
            // TituloSistema
            // 
            this.TituloSistema.AutoSize = true;
            this.TituloSistema.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TituloSistema.Location = new System.Drawing.Point(13, 27);
            this.TituloSistema.Name = "TituloSistema";
            this.TituloSistema.Size = new System.Drawing.Size(158, 13);
            this.TituloSistema.TabIndex = 1;
            this.TituloSistema.Text = "Registro de Productos - Bodega";
            this.TituloSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(240, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 238);
            this.panel1.TabIndex = 2;
            // 
            // listProductos
            // 
            this.listProductos.Controls.Add(this.dataGridView1);
            this.listProductos.Location = new System.Drawing.Point(522, 65);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(536, 498);
            this.listProductos.TabIndex = 3;
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(31, 56);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(138, 23);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(31, 171);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(138, 23);
            this.buttonReportes.TabIndex = 1;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.Location = new System.Drawing.Point(31, 115);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(138, 23);
            this.buttonBuscarProducto.TabIndex = 2;
            this.buttonBuscarProducto.Text = "Buscar Productos";
            this.buttonBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // buttonBienvenida
            // 
            this.buttonBienvenida.Location = new System.Drawing.Point(3, 3);
            this.buttonBienvenida.Name = "buttonBienvenida";
            this.buttonBienvenida.Size = new System.Drawing.Size(197, 23);
            this.buttonBienvenida.TabIndex = 3;
            this.buttonBienvenida.Text = "Bienvenido ADMIN";
            this.buttonBienvenida.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonCerrar.Location = new System.Drawing.Point(31, 478);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCerrar.Size = new System.Drawing.Size(138, 41);
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.Text = "Cerrar Sesion";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio (S/.)";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(18, 44);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(223, 20);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(18, 112);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(223, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistrar.Location = new System.Drawing.Point(18, 168);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(223, 43);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar Producto";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1070, 610);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TituloSistema);
            this.Controls.Add(this.barraLateral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.listProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraLateral;
        private System.Windows.Forms.Label TituloSistema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listProductos;
        private System.Windows.Forms.Button buttonBienvenida;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

