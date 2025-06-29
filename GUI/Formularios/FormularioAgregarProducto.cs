using uai_poo_actividad_integradora_3.Clases;
using uai_poo_actividad_integradora_3.Utilidades;

namespace uai_poo_actividad_integradora_3.GUI.Formularios
{
    public partial class FormularioAgregarProducto : Form
    {
        public Producto Producto { get; set; }

        public FormularioAgregarProducto()
        {
            InitializeComponent();
        }

        private void ValidarCampos(object sender, EventArgs e) => botonAgregarProducto.Enabled = ValidarId() && ValidarDescripcion() && ValidarPrecio() && ValidarStock();

        private bool ValidarStock()
        {
            var stock = campoNumericoStock.Value;
            return stock >= 1 && stock <= 100;
        }

        private bool ValidarPrecio()
        {
            var precio = campoNumericoPrecio.Value;
            return precio >= 100 && precio <= 100000000;
        }

        private bool ValidarDescripcion() => !string.IsNullOrWhiteSpace(campoDeTextoDescripcion.Text);

        private bool ValidarId() => UtilidadesRegex.ValidarIdProducto(campoDeTextoEnmascaradoId.Text);

        private void BotonAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto = new Producto(
                campoDeTextoEnmascaradoId.Text,
                campoDeTextoDescripcion.Text,
                campoNumericoPrecio.Value,
                (uint)campoNumericoStock.Value
            );
            DialogResult = DialogResult.OK;
        }
    }
}
