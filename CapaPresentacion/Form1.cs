using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private Cuenta cuentaActual;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Ahorros");
            cmbTipo.Items.Add("Corriente");
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCuenta.Clear();
            cmbTipo.SelectedIndex = -1;
            txtSaldoActual.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor ingrese un ID.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("El ID debe ser un número entero.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CNPersonas cn = new CNPersonas();
            cuentaActual = cn.ObtenerCuentaPorId(id); // busca en la base de datos

            if (cuentaActual != null)
            {
                txtNombre.Text = cuentaActual.Nombre;
                txtCuenta.Text = cuentaActual.NumCuenta;
                cmbTipo.SelectedItem = cuentaActual.TipoCuenta;
                txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");
            }
            else
            {
                MessageBox.Show("Cuenta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (cuentaActual == null)
            {
                MessageBox.Show("Primero busca una cuenta.");
                return;
            }

            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                string mensaje = cuentaActual.Depositar(monto);
                MessageBox.Show(mensaje);

                // Actualiza el saldo en base de datos
                CNPersonas cn = new CNPersonas();
                cn.ActualizarSaldo(cuentaActual.Id, cuentaActual.SaldoCuenta);

                txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");
            }
            else
            {
                MessageBox.Show("Monto inválido.");
            }
        }

        private void lblRetirar_Click(object sender, EventArgs e)
        {
            if (cuentaActual == null)
            {
                MessageBox.Show("Primero busca una cuenta.");
                return;
            }

            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                string mensaje = cuentaActual.Retirar(monto);
                MessageBox.Show(mensaje);

                // Solo actualiza si el retiro fue exitoso
                if (mensaje.StartsWith("Retiro"))
                {
                    CNPersonas cn = new CNPersonas();
                    cn.ActualizarSaldo(cuentaActual.Id, cuentaActual.SaldoCuenta);
                    txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Monto inválido.");
            }
        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {
            if (cuentaActual == null)
            {
                MessageBox.Show("Primero busca una cuenta.");
                return;
            }

            string mensaje = cuentaActual.ConsultarSaldo();
            MessageBox.Show(mensaje);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCuenta.Clear();
            txtNombre.Clear();
            cmbTipo.SelectedIndex = -1; // deselecciona cualquier valor
            txtSaldoActual.Clear();
            txtMonto.Clear();

            cuentaActual = null; // Reinicia la cuenta cargada
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


           if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCuenta.Text) ||
                 cmbTipo.SelectedItem == null ||
                 string.IsNullOrWhiteSpace(txtSaldoActual.Text))
           {
                MessageBox.Show("Por favor completa todos los campos.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }

            decimal saldo;
                if (!decimal.TryParse(txtSaldoActual.Text, out saldo))
                {
                    MessageBox.Show("Saldo inválido. Ingresa un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            Cuenta nuevaCuenta = cmbTipo.SelectedItem.ToString() == "Ahorros" ? new CuentaAhorro() : new CuentaCorriente();

            nuevaCuenta.Nombre = txtNombre.Text;
            nuevaCuenta.NumCuenta = txtCuenta.Text;
            nuevaCuenta.TipoCuenta = cmbTipo.SelectedItem.ToString();
            nuevaCuenta.SaldoCuenta = saldo;

            CNPersonas cn = new CNPersonas();
            bool insertado = cn.AgregarCuenta(nuevaCuenta);

            if (insertado)
            {
                MessageBox.Show("Cuenta agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
