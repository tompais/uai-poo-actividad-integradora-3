using uai_poo_actividad_integradora_3.Clases;
using uai_poo_actividad_integradora_3.Enumerables;

namespace uai_poo_actividad_integradora_3.Comparadores
{
    public class ComparadorIdProducto(Orden orden = Orden.ASC) : ComparadorBase<Producto>(orden)
    {
        public override int Compare(Producto? x, Producto? y) => Orden switch
        {
            Orden.ASC => string.Compare(x?.Id, y?.Id),
            _ => string.Compare(y?.Id, x?.Id),
        };
    }
}
