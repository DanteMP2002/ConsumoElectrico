
namespace Ejercicio05_ConsumoElectrico
{
    public partial class frmRegistro : Form
    {
        // Declaramos las variables que vamos a utilizar
        int consumoCalculado = 0;
        decimal tarifaAplicada = 0m;
        decimal montoConsumo = 0m;
        decimal recargo = 0m;
        decimal bono = 0m;
        decimal totalPago = 0m;
        public frmRegistro()
        {
            InitializeComponent();

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Lipiamos el nombre del cliente
            txtNombreCliente.Clear();

            // Limpiamos las lecturas
            numLecturaActual.Value = 0;
            numLecturaAnterior.Value = 0;

            // Limpiamos el tipo de cliente
            cboTipoCliente.SelectedIndex = -1;

            // Limpiamos los radio buttons
            rdbNinguno.Checked = true;

            // enfocamos el nombre del cliente
            txtNombreCliente.Focus();
        }

        private void btnCalcularRecibo_Click(object sender, EventArgs e)
        {
            // Validamos antes de calcular el recibo
            // debe tener un nombre de cliente
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show(
                    "Nombre del cliente es requerido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                txtNombreCliente.Focus(); // Enfocar para resaltar 
                return;
            }

            // debe tener una lectura anterior mayor a 0
            if (numLecturaAnterior.Value <= 0)
            {
                MessageBox.Show(
                    "Debe ingresar la lectura anterior", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                numLecturaAnterior.Focus();
                return;
            }

            // debe tener una lectura actual mayor a 0
            if (numLecturaActual.Value <= 0)
            {
                MessageBox.Show(
                    "Debe ingresar la lectura actual", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                numLecturaActual.Focus();
                return;
            }

            // la lectura actual no puede ser menor a la lectura anterior
            if (numLecturaActual.Value < numLecturaAnterior.Value)
            {
                MessageBox.Show(
                    "La lectura actual no puede ser menor a la lectura anterior",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                numLecturaActual.Focus();
                return;
            }

            // Calculamos el consumo 
            consumoCalculado = (int)(numLecturaActual.Value - numLecturaAnterior.Value);

            // Calculamos la tarifa
            // segun su consumo calculado y el tipo de cliente
            switch (cboTipoCliente.SelectedItem?.ToString())
            {
                // Calculamos la tarifa domestica segun el consumo calculado
                case "Doméstico":
                    tarifaAplicada = (consumoCalculado <= 100) ? 0.65m :
                                    (consumoCalculado <= 300) ? 0.85m : 1.1m;
                    break;
                // Calculamos la tarifa comercial segun el consumo calculado
                case "Comercial":
                    tarifaAplicada = (consumoCalculado <= 200) ? 0.95m : 1.25m;
                    break;
                default: // Si no se selecciona un tipo de cliente, mostramos un mensaje de error
                    MessageBox.Show(
                        "Debe seleccionar un tipo de cliente",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    cboTipoCliente.Focus();
                    return;
            }

            // Calculamos el recargo si el cliente tiene alumbrado público
            recargo = (rdbAlumbrado.Checked) ? 18m : 0m;

            // calculamos el Monto por su consumo
            montoConsumo = consumoCalculado * tarifaAplicada;

            // aplicar bono si el consumo es menor o igual a 80 kWh 
            // aplicar bono si el monto es mayor a 12 
            // independientemente si tiene o no alumbrado público
            bono = (consumoCalculado <= 80 && montoConsumo > 12m) ? 12m : 0m;

            // calculamos el total a pagar
            totalPago = montoConsumo + recargo - bono;

            // Creamos la ventana de resultado
            // Enviamos los datos a la ventana de resultado
            // por un constructor que recibe los datos
            frmResultado FormResultado = new frmResultado(
                txtNombreCliente.Text,
                consumoCalculado,
                tarifaAplicada,
                montoConsumo,
                recargo,
                bono,
                totalPago
            );

            // Mostramos la ventana de resultado
            FormResultado.ShowDialog();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
