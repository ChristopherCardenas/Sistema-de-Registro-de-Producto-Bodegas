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
    /// Formulario principal para el registro y visualización de productos en la bodega.
    /// Permite registrar productos, visualizar la lista y acceder a otras funcionalidades.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario Form1 y lo centra en pantalla.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Registra un nuevo producto si no existe previamente.
        /// Asocia el nombre, código y precio seleccionado.
        /// </summary>
        
        private void RegistrarProducto(string nombre, string codigo, int indicePrecio)
        {
            if (!DatosProductos.Productos.Contains(nombre) && !DatosProductos.CodigosProductos.ContainsKey(codigo))
            {
                DatosProductos.Productos.Add(nombre);
                DatosProductos.CodigosProductos[codigo] = nombre;
                DatosProductos.PreciosPorCodigo[codigo] = DatosProductos.PreciosSemana[indicePrecio];
                MessageBox.Show($"Producto '{nombre}' registrado con código '{codigo}' y precio {DatosProductos.PreciosSemana[indicePrecio]:C}");
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("El producto o código ya existe.");
            }
        }

        /// <summary>
        /// Evento de carga del formulario. Inicializa los precios y las columnas de la tabla.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPrecios.Items.Clear();
            foreach (var precio in DatosProductos.PreciosSemana)
            {
                comboBoxPrecios.Items.Add(precio.ToString("S/."));
            }

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Codigo", "Código");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Precio", "Precio");
            }
            ActualizarDataGridView();
        }

        private void label1_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Abre el formulario de búsqueda de productos y cierra el formulario actual.
        /// </summary>
        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show();
            
        }

        /// <summary>
        /// Cierra la sesión del usuario tras confirmación.
        /// </summary>
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void listProductos_Paint(object sender, PaintEventArgs e) { }
        private void buttonInicio_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Muestra un mensaje indicando que la funcionalidad de reportes no está implementada.
        /// </summary>
        private void buttonReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada. Espera la siguiente versión.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barraLateral_Paint(object sender, PaintEventArgs e) { }
        private void buttonBienvenida_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtNombreProducto_TextChanged(object sender, EventArgs e) { }
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Valida los campos y registra el producto al presionar el botón Registrar.
        /// </summary>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            string codigo = txtCodigoProducto.Text;
            int indicePrecio = comboBoxPrecios.SelectedIndex;

            if (indicePrecio >= 0 && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(codigo))
            {
                RegistrarProducto(nombre, codigo, indicePrecio);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Completa todos los campos.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Actualiza la visualización de la tabla de productos.
        /// </summary>
        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var codigo in DatosProductos.CodigosProductos.Keys)
            {
                string nombre = DatosProductos.CodigosProductos[codigo];
                decimal precio = DatosProductos.PreciosPorCodigo.ContainsKey(codigo) ? DatosProductos.PreciosPorCodigo[codigo] : 0;
                dataGridView1.Rows.Add(codigo, nombre, precio.ToString("S/."));
            }
        }
    }
}
