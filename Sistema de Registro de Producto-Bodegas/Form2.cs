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
    /// <summary>
    /// Formulario para la búsqueda de productos por código.
    /// Permite consultar el nombre y precio de un producto registrado.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario Form2 y lo centra en pantalla.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Al presionar "Inicio", abre el formulario principal y cierra el actual.
        /// </summary>
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        /// <summary>
        /// Cierra la aplicación tras confirmación del usuario.
        /// </summary>
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Busca un producto por código y muestra el resultado en pantalla.
        /// </summary>
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

        /// <summary>
        /// Muestra un mensaje indicando que la funcionalidad de reportes no está implementada.
        /// </summary>
        private void buttonReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada. Espera la siguiente versión.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
