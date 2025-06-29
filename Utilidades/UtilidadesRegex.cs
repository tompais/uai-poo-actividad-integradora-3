using System.Text.RegularExpressions;
using uai_poo_actividad_integradora_3.Constantes;

namespace uai_poo_actividad_integradora_3.Utilidades
{
    public static partial class UtilidadesRegex
    {
        [GeneratedRegex(ExpresionesRegulares.PRODUCTO_ID)]
        private static partial Regex RegexProductoId();

        public static bool ValidarIdProducto(string id) => RegexProductoId().IsMatch(id);
    }
}
