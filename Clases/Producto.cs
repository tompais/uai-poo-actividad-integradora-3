using System.Collections;
using uai_poo_actividad_integradora_3.Interfaces;

namespace uai_poo_actividad_integradora_3.Clases
{
    public class Producto(string id, string descripcion, decimal precio, uint stock = 0u) : IProducto
    {
        public string Id { get; set; } = id;
        public string Descripcion { get; set; } = descripcion;
        public decimal Precio { get; set; } = precio;
        public uint Stock { get; set; } = stock;
        private string _current = string.Empty;
        private ushort counter = 0;

        public object Current => _current;

        public object Clone() => MemberwiseClone();

        public IEnumerator GetEnumerator() => this;

        public bool MoveNext()
        {
            switch (counter++)
            {
                case 0:
                    _current = $"Código de Producto: {Id[..3]}";
                    break;
                case 1:
                    _current = $"Número de Línea {Id.Substring(4, 3)}";
                    break;
                case 2:
                    _current = $"Código de Operador {Id.Substring(8, 5)}";
                    break;
                case 3:
                    _current = $"Fecha de Fabricación {Id.Substring(14, 10)}";
                    break;
                default:
                    Reset();
                    break;
            }
            return counter != 0u;
        }

        public void Reset()
        {
            _current = string.Empty;
            counter = 0;
        }
    }
}
