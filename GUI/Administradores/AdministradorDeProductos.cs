using uai_poo_actividad_integradora_3.Clases;
using uai_poo_actividad_integradora_3.Comparadores;
using uai_poo_actividad_integradora_3.Constantes;
using uai_poo_actividad_integradora_3.Enumerables;
using uai_poo_actividad_integradora_3.GUI.Formularios;

namespace uai_poo_actividad_integradora_3.GUI.Grillas
{
    public partial class AdministradorDeProductos : Form
    {
        private readonly List<Producto> Productos = [];
        private Orden Orden { get; set; } = Orden.ASC;
        private string ColumnaOrdenada { get; set; } = NombreColumna.ID;
        public AdministradorDeProductos()
        {
            InitializeComponent();
        }

        private void BotonAgregarProducto_Click(object sender, EventArgs e)
        {
            using var formularioAgregarProducto = new FormularioAgregarProducto();
            if (formularioAgregarProducto.ShowDialog() == DialogResult.OK)
            {
                AgregarProductoAGrillaYActualizarla(formularioAgregarProducto.Producto);
                ActualizarEstadoBotones();
            }
        }

        private void AgregarProductoAGrillaYActualizarla(Producto producto)
        {
            AgregarProductoALista(producto);
            ActualizarGrilla();
        }

        private void AgregarProductoALista(Producto producto) => Productos.Add(producto);

        private void ActualizarEstadoBotones() => botonBorrarProducto.Enabled = botonModificarProducto.Enabled = botonClonarProducto.Enabled = botonMostrarPartesDelID.Enabled = HayProductosEnGrilla() && HayFilaSeleccionadaEnGrilla();

        private bool HayProductosEnGrilla() => grillaDeProductos.Rows.Count > 0;

        private void ActualizarGrilla()
        {
            LimpiarGrillaDeProductos();
            CargarProductosEnGrilla();
        }

        private void CargarProductosEnGrilla() => Productos.ForEach(AgregarProductoAGrilla);

        private void LimpiarGrillaDeProductos() => grillaDeProductos.Rows.Clear();

        private void AgregarProductoAGrilla(Producto producto) => grillaDeProductos.Rows.Add(producto.Id, producto.Descripcion, producto.Precio, producto.Stock);

        private void BotonBorrarProducto_Click(object sender, EventArgs e)
        {
            if (HayFilaSeleccionadaEnGrilla())
            {
                BorrarProductoSeleccionado();
                ActualizarGrilla();
                ActualizarEstadoBotones();
            }
        }

        private void BorrarProductoSeleccionado() => EliminarProductoPorIndice(ObtenerIndiceFilaSeleccionada());

        private void EliminarProductoPorIndice(int indiceFilaSeleccionada) => Productos.RemoveAt(indiceFilaSeleccionada);

        private int ObtenerIndiceFilaSeleccionada() => grillaDeProductos.SelectedRows[0].Index;

        private bool HayFilaSeleccionadaEnGrilla() => grillaDeProductos.SelectedRows.Count > 0;

        private void BotonModificarProducto_Click(object sender, EventArgs e)
        {
            if (HayFilaSeleccionadaEnGrilla())
            {
                using var formularioModificarProducto = new FormularioModificarProducto(ObtenerProductoSeleccionado());
                if (formularioModificarProducto.ShowDialog() == DialogResult.OK)
                {
                    Productos[ObtenerIndiceFilaSeleccionada()] = formularioModificarProducto.Producto;
                    ActualizarGrilla();
                    ActualizarEstadoBotones();
                }
            }
        }

        private Producto ObtenerProductoSeleccionado() => Productos[ObtenerIndiceFilaSeleccionada()];

        private void GrillaDeProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var nombreColumna = grillaDeProductos.Columns[e.ColumnIndex].Name;
            if (nombreColumna.Equals(ColumnaOrdenada))
            {
                Orden = Orden == Orden.ASC ? Orden.DESC : Orden.ASC;
            }
            else
            {
                ColumnaOrdenada = nombreColumna;
                Orden = Orden.ASC;
            }

            OrdenarProductos();
        }

        private void OrdenarProductos()
        {
            OrdenarListaDeProductos();
            ActualizarGrilla();
        }

        private void OrdenarListaDeProductos() => Productos.Sort(ObtenerComparadorDeProductos());

        private IComparer<Producto> ObtenerComparadorDeProductos() => ColumnaOrdenada switch
        {
            NombreColumna.ID => new ComparadorIdProducto(Orden),
            NombreColumna.PRECIO => new ComparadorPrecioProducto(Orden),
            _ => throw new ArgumentException("Columna no válida")
        };

        private void BotonClonarProducto_Click(object sender, EventArgs e)
        {
            if (HayFilaSeleccionadaEnGrilla())
            {
                AgregarProductoAGrillaYActualizarla(ClonarProductoSeleccionadoEnGrilla());
            }
        }

        private Producto ClonarProductoSeleccionadoEnGrilla() => (Producto)ObtenerProductoSeleccionado().Clone();

        private void GrillaDeProductos_SelectionChanged(object sender, EventArgs e) => ActualizarEstadoBotones();

        private void BotonMostrarPartesDelID_Click(object sender, EventArgs e)
        {
            if (HayFilaSeleccionadaEnGrilla())
            {
                using var formularioMostrarPartesID = new FormularioMostrarPartesID(ObtenerProductoSeleccionado());
                formularioMostrarPartesID.ShowDialog();
            }
        }
    }
}
