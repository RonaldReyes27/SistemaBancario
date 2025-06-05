using System;
using System.Windows.Forms;
using CapaNegocios;
using Microsoft.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private Cuenta cuentaActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTablaCuentas();
        }

        private void CargarTablaCuentas()
        {
            CNPersonas cn = new CNPersonas();
            dgvCuentas.DataSource = cn.ObtenerTodasLasCuentas();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCuenta.Clear();
            txtTipo.Clear();
            txtSaldoActual.Clear();
            txtMonto.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor ingrese un ID.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CNPersonas cn = new CNPersonas();
            cuentaActual = cn.ObtenerCuentaPorId(id);

            if (cuentaActual != null)
            {
                txtNombre.Text = cuentaActual.Nombre;
                txtCuenta.Text = cuentaActual.NumCuenta;
                txtTipo.Text = cuentaActual.TipoCuenta;
                txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");
            }
            else
            {
                MessageBox.Show("Cuenta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
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

                CNPersonas cn = new CNPersonas();
                cn.ActualizarSaldo(cuentaActual.Id, cuentaActual.SaldoCuenta);

                txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");
                CargarTablaCuentas();
            }
            else
            {
                MessageBox.Show("Monto inválido.");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
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

                if (mensaje.StartsWith("Retiro"))
                {
                    CNPersonas cn = new CNPersonas();
                    cn.ActualizarSaldo(cuentaActual.Id, cuentaActual.SaldoCuenta);
                    txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");
                    CargarTablaCuentas();
                }
            }
            else
            {
                MessageBox.Show("Monto inválido.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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
            LimpiarCampos();
            cuentaActual = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvCuentas.Rows[e.RowIndex];
                string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
                txtId.Text = idSeleccionado;
                btnBuscar.PerformClick();
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

            // Reconsultar desde la base de datos
            CNPersonas cn = new CNPersonas();
            Cuenta cuentaActualizada = cn.ObtenerCuentaPorId(cuentaActual.Id);

            if (cuentaActualizada != null)
            {
                cuentaActual = cuentaActualizada; // actualizar referencia en memoria

                txtSaldoActual.Text = cuentaActual.SaldoCuenta.ToString("N2");

                string mensaje = cuentaActual.ConsultarSaldo();
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No se pudo obtener la cuenta actualizada.");
            }
        }

       

       
    }
}
