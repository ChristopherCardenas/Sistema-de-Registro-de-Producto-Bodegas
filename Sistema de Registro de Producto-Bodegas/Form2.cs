using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro_de_Producto_Bodegas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e) { }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscarCodigo.Text.Trim();
            if (DatosProductos.CodigosProductos.TryGetValue(codigo, out string nombre))
            {
                int indice = DatosProductos.Productos.IndexOf(nombre);
                decimal precio = (indice >= 0 && indice < DatosProductos.PreciosSemana.Length)
                    ? DatosProductos.PreciosSemana[indice]
                    : 0;
                lblResultado.Text = $"Nombre: {nombre}\nPrecio: S/. {precio}";
            }
            else
            {
                lblResultado.Text = "Producto no encontrado.";
            }
        }

        private void lblResultado_Click(object sender, EventArgs e) { }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada. Espera la siguiente versión.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
