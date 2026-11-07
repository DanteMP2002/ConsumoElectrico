namespace Ejercicio05_ConsumoElectrico
{
    public partial class frmResultado : Form
    {
       
        public frmResultado()
        {
            InitializeComponent();
        }

        // Constructor que recibe los valores calculados
        // los muestra en la ventana de resultado
        public frmResultado(
            string nombreCliente, int consumoCalculado, decimal tarifaAplicada, 
            decimal montoConsumo, decimal recargo, decimal bono, decimal totalPago
            )
        {
            InitializeComponent();

            // Asignar los valores a los controles de la ventana

            // Nombre del cliente
            lblNombreClienteValor.Text = nombreCliente;

            // Consumo calculado
            lblConsumoCalculadoValor.Text =consumoCalculado.ToString() + "  Kwh";

            // Tarifa aplicada
            lblTarifaValor.Text = "S/ " + tarifaAplicada.ToString("N2");

            // Monto del consumo
            lblMontoConsumoValor.Text = "S/ " + montoConsumo.ToString("N2");

            // Recargo
            lblRecargoValor.Text = " S/ " + recargo.ToString("N2");
            if (recargo == 0)
            {
                pnlRecargo.BackColor = Color.Gray;
            }
            else
            {
                lblRecargoValor.Text = "+"+ lblRecargoValor.Text;
            }

            // Bono
            lblBonoValor.Text = " S/ " + bono.ToString("N2");
            if (bono == 0)
            {
                pnlBono.BackColor = Color.Gray;
            }
            else
            {
                lblBonoValor.Text = "-" + lblBonoValor.Text;
            }

            // Total a pagar
            lblTotalPagoValor.Text = "S/ " + totalPago.ToString("N2");
        }
        private void frmResultado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
