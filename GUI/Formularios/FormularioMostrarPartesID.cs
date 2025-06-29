using uai_poo_actividad_integradora_3.Clases;

namespace uai_poo_actividad_integradora_3.GUI.Formularios
{
    public partial class FormularioMostrarPartesID : Form
    {
        private readonly Producto Producto;
        public FormularioMostrarPartesID(in Producto producto)
        {
            Producto = producto;
            InitializeComponent();
        }

        private void FormularioMostrarPartesID_Load(object sender, EventArgs e)
        {
            foreach (var parte in Producto)
            {
                campoDeTextoPartesID.Text += parte.ToString() + Environment.NewLine;
            }
        }
    }
}
