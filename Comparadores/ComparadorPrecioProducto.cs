using uai_poo_actividad_integradora_3.Clases;
using uai_poo_actividad_integradora_3.Enumerables;

namespace uai_poo_actividad_integradora_3.Comparadores
{
    public class ComparadorPrecioProducto(Orden orden = Orden.ASC) : ComparadorBase<Producto>(orden)
    {
        public override int Compare(Producto? x, Producto? y) => Orden switch
        {
            Orden.ASC => x?.Precio.CompareTo(y?.Precio) ?? 0,
            _ => y?.Precio.CompareTo(x?.Precio) ?? 0,
        };
    }
}
