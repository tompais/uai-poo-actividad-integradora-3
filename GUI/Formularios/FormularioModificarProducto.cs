using uai_poo_actividad_integradora_3.Clases;
using uai_poo_actividad_integradora_3.Utilidades;

namespace uai_poo_actividad_integradora_3.GUI.Formularios
{
    public partial class FormularioModificarProducto : Form
    {
        public readonly Producto Producto;
        public FormularioModificarProducto(in Producto producto)
        {
            Producto = producto;
            InitializeComponent();
        }

        private void FormularioModificarProducto_Load(object sender, EventArgs e)
        {
            campoDeTextoEnmascaradoId.Text = Producto.Id.ToString();
            campoDeTextoDescripcion.Text = Producto.Descripcion;
            campoNumericoPrecio.Value = Producto.Precio;
            campoNumericoStock.Value = Producto.Stock;
        }

        private void ValidarCampos(object sender, EventArgs e) => botonModificarProducto.Enabled = ValidarId() && ValidarDescripcion() && ValidarPrecio() && ValidarStock();

        private bool ValidarStock()
        {
            var stock = campoNumericoStock.Value;
            return stock >= 0 && stock <= 100;
        }

        private bool ValidarPrecio()
        {
            var precio = campoNumericoPrecio.Value;
            return precio >= 100 && precio <= 100000000;
        }

        private bool ValidarDescripcion() => !string.IsNullOrWhiteSpace(campoDeTextoDescripcion.Text);

        private bool ValidarId() => UtilidadesRegex.ValidarIdProducto(campoDeTextoEnmascaradoId.Text);

        private void BotonModificarProducto_Click(object sender, EventArgs e)
        {
            Producto.Id = campoDeTextoEnmascaradoId.Text;
            Producto.Descripcion = campoDeTextoDescripcion.Text;
            Producto.Precio = campoNumericoPrecio.Value;
            Producto.Stock = (uint)campoNumericoStock.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
