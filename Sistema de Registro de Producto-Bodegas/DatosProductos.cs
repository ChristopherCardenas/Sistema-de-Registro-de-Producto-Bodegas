using System.Collections.Generic;

namespace Sistema_de_Registro_de_Producto_Bodegas
{
    /// <summary>
    /// Clase est�tica que almacena los datos globales de productos para la aplicaci�n.
    /// Proporciona acceso a los c�digos, nombres y precios de los productos registrados.
    /// </summary>
    public static class DatosProductos
    {
        /// <summary>
        /// Diccionario que asocia el c�digo de producto (clave) con el nombre del producto (valor).
        /// Permite b�squedas r�pidas de productos por su c�digo.
        /// </summary>
        public static Dictionary<string, string> CodigosProductos { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Lista de nombres de productos registrados en el sistema.
        /// El �ndice de cada producto corresponde al �ndice de su precio en <see cref="PreciosSemana"/>.
        /// </summary>
        public static List<string> Productos { get; } = new List<string>();

        /// <summary>
        /// Arreglo de precios de productos para la semana.
        /// Cada posici�n corresponde al producto en el mismo �ndice de <see cref="Productos"/>.
        /// </summary>
        public static decimal[] PreciosSemana { get; } = { 10.00m, 15.00m, 8.00m, 12.00m, 9.00m, 14.00m, 11.00m };

        /// <summary>
        /// Diccionario que asocia el c�digo de producto (clave) con su precio (valor).
        /// Permite acceder r�pidamente al precio de un producto dado su c�digo.
        /// </summary>
        public static Dictionary<string, decimal> PreciosPorCodigo { get; } = new Dictionary<string, decimal>();
    }
}