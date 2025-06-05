using Microsoft.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CNPersonas
    {
        // Obtiene una cuenta por su Id y devuelve un objeto del tipo correcto (Ahorro o Corriente)
        public Cuenta ObtenerCuentaPorId(int idBusqueda)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.conexion))
            {
                conn.Open();

                //consulta sql para buscar por id
                string query = "SELECT * FROM CuentaCliente WHERE Id = @Id";

                //sql comando 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idBusqueda); // agregar parametro de busqueda 

                //Ejecutando la consulta 
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string tipoCuenta = reader["TipoCuenta"].ToString();
                    Cuenta cuenta = tipoCuenta == "Ahorros" ? new CuentaAhorro() : new CuentaCorriente();

                    cuenta.Id = Convert.ToInt32(reader["Id"]);
                    cuenta.NumCuenta = reader["NumCuenta"].ToString();
                    cuenta.Nombre = reader["Nombre"].ToString();
                    cuenta.TipoCuenta = tipoCuenta;
                    cuenta.SaldoCuenta = Convert.ToDecimal(reader["SaldoCuenta"]);

                    return cuenta;
                }
                return null;
            }
        }

       

        // Actualiza el saldo de una cuenta existente
        public void ActualizarSaldo(int idCuenta, decimal nuevoSaldo)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.conexion))
            {
                conn.Open();
                string query = "UPDATE CuentaCliente SET SaldoCuenta = @Saldo WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Saldo", nuevoSaldo);
                cmd.Parameters.AddWithValue("@Id", idCuenta);
                cmd.ExecuteNonQuery();
            }
        }

        // 🔹 Método para obtener todos los ID y Nombres de cuentas
        public DataTable ObtenerTodasLasCuentas()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.conexion))
            {
                string query = "SELECT Id, Nombre FROM CuentaCliente";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
    }

    // Clase Cuenta: Esta es la clase principal la cual contiene los atributos que van a ser heredados 
    public class Cuenta
    {
        public int Id { get; set; }
        public string NumCuenta { get; set; }
        public string Nombre { get; set; }
        public string TipoCuenta { get; set; }
        public decimal SaldoCuenta { get; set; }

        public virtual string Depositar(decimal monto)
        {
            SaldoCuenta += monto;
            return $"Deposito exitoso. Nuevo Saldo: {SaldoCuenta:C2}";
        }

        public virtual string Retirar(decimal monto)
        {
            SaldoCuenta -= monto;
            return $"Retiro exitoso. Nuevo saldo: {SaldoCuenta:C2}";
        }

        public string ConsultarSaldo()
        {
            return $"Saldo actual: {SaldoCuenta:C2}";
        }
    }

    public class CuentaAhorro : Cuenta //clase ahorro con herencia en cuenta 
    {
        public override string Retirar(decimal monto)
        {
            if (SaldoCuenta >= monto)
            {
                SaldoCuenta -= monto;
                return $"Retiro exitoso (Ahorro). Nuevo saldo: {SaldoCuenta:C2}";
            }

            return "No puedes retirar más de lo que tienes en tu cuenta de ahorro.";
        }
    }

    public class CuentaCorriente : Cuenta // clase corriente con herencia en cuenta
    {
        public override string Retirar(decimal monto)
        {
            if (SaldoCuenta >= monto)
            {
                SaldoCuenta -= monto;
                return $"Retiro exitoso (Corriente). Nuevo saldo: {SaldoCuenta:C2}";
            }

            return "No puedes retirar más de lo que tienes en tu cuenta corriente.";
        }
    }
}
