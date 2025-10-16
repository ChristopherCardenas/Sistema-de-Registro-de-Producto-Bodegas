using System.Collections.Generic;

namespace Sistema_de_Registro_de_Producto_Bodegas
{
    public static class DatosProductos
    {
        public static Dictionary<string, string> CodigosProductos { get; } = new Dictionary<string, string>();
        public static Dictionary<string, decimal> PreciosPorCodigo { get; } = new Dictionary<string, decimal>();
        public static List<string> Productos { get; } = new List<string>();
        public static decimal[] PreciosSemana { get; } = { 10.00m, 15.00m, 8.00m, 12.00m, 9.00m, 14.00m, 11.00m };
    }
}