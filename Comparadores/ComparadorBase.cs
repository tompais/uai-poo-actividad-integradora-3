using uai_poo_actividad_integradora_3.Enumerables;

namespace uai_poo_actividad_integradora_3.Comparadores
{
    public abstract class ComparadorBase<T>(Orden orden) : IComparer<T>
    {
        protected readonly Orden Orden = orden;
        public abstract int Compare(T? x, T? y);
    }
}
