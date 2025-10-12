namespace Sistema_de_Registro_de_Producto_Bodegas
{
    partial class Form2
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
            this.listProductosBuscar = new System.Windows.Forms.Panel();
            this.panel1Buscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TituloSistema = new System.Windows.Forms.Label();
            this.barraLateral = new System.Windows.Forms.Panel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonBienvenida = new System.Windows.Forms.Button();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1Buscar.SuspendLayout();
            this.barraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProductosBuscar
            // 
            this.listProductosBuscar.Location = new System.Drawing.Point(239, 161);
            this.listProductosBuscar.Name = "listProductosBuscar";
            this.listProductosBuscar.Size = new System.Drawing.Size(789, 383);
            this.listProductosBuscar.TabIndex = 8;
            // 
            // panel1Buscar
            // 
            this.panel1Buscar.Controls.Add(this.btnBuscar);
            this.panel1Buscar.Controls.Add(this.txtBuscarCodigo);
            this.panel1Buscar.Controls.Add(this.label2);
            this.panel1Buscar.Controls.Add(this.label1);
            this.panel1Buscar.Location = new System.Drawing.Point(239, 64);
            this.panel1Buscar.Name = "panel1Buscar";
            this.panel1Buscar.Size = new System.Drawing.Size(789, 88);
            this.panel1Buscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Location = new System.Drawing.Point(251, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(22, 45);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(223, 20);
            this.txtBuscarCodigo.TabIndex = 2;
            this.txtBuscarCodigo.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Producto por Codigo";
            // 
            // TituloSistema
            // 
            this.TituloSistema.AutoSize = true;
            this.TituloSistema.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TituloSistema.Location = new System.Drawing.Point(12, 26);
            this.TituloSistema.Name = "TituloSistema";
            this.TituloSistema.Size = new System.Drawing.Size(177, 13);
            this.TituloSistema.TabIndex = 6;
            this.TituloSistema.Text = "Registro de Productos - BodegaSoft";
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraLateral.Controls.Add(this.buttonCerrar);
            this.barraLateral.Controls.Add(this.buttonBienvenida);
            this.barraLateral.Controls.Add(this.buttonBuscarProducto);
            this.barraLateral.Controls.Add(this.buttonReportes);
            this.barraLateral.Controls.Add(this.buttonInicio);
            this.barraLateral.Location = new System.Drawing.Point(15, 61);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(203, 536);
            this.barraLateral.TabIndex = 5;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonCerrar.Location = new System.Drawing.Point(35, 479);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCerrar.Size = new System.Drawing.Size(138, 41);
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.Text = "Cerrar Sesion";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonBienvenida
            // 
            this.buttonBienvenida.Location = new System.Drawing.Point(4, 4);
            this.buttonBienvenida.Name = "buttonBienvenida";
            this.buttonBienvenida.Size = new System.Drawing.Size(197, 23);
            this.buttonBienvenida.TabIndex = 3;
            this.buttonBienvenida.Text = "Bienvenido ADMIN";
            this.buttonBienvenida.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.Location = new System.Drawing.Point(35, 116);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(138, 23);
            this.buttonBuscarProducto.TabIndex = 2;
            this.buttonBuscarProducto.Text = "Buscar Productos";
            this.buttonBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(35, 172);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(138, 23);
            this.buttonReportes.TabIndex = 1;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(35, 57);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(138, 23);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(236, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar Productos - Administrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(408, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "© 2025 BodegaSoft – Sistema de Gestión de Bodega. Todos los derechos reservados.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1060, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listProductosBuscar);
            this.Controls.Add(this.panel1Buscar);
            this.Controls.Add(this.TituloSistema);
            this.Controls.Add(this.barraLateral);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1Buscar.ResumeLayout(false);
            this.panel1Buscar.PerformLayout();
            this.barraLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel listProductosBuscar;
        private System.Windows.Forms.Panel panel1Buscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TituloSistema;
        private System.Windows.Forms.Panel barraLateral;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonBienvenida;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}