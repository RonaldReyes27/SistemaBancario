using Microsoft.Data.SqlClient;
using CapaDatos;



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

                //consulta sql para buscara por id
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




        public bool AgregarCuenta(Cuenta cuenta)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.conexion))
            {
                conn.Open();

                string query = "INSERT INTO CuentaCliente (NumCuenta, Nombre, TipoCuenta, SaldoCuenta) VALUES (@NumCuenta, @Nombre, @TipoCuenta, @SaldoCuenta)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumCuenta", cuenta.NumCuenta);
                cmd.Parameters.AddWithValue("@Nombre", cuenta.Nombre);
                cmd.Parameters.AddWithValue("@TipoCuenta", cuenta.TipoCuenta);
                cmd.Parameters.AddWithValue("@SaldoCuenta", cuenta.SaldoCuenta);

                return cmd.ExecuteNonQuery() > 0;
            }
        }





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
    }


}
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
            return $"Deposito exitoso.Nuevo Saldo {SaldoCuenta:C2}";
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
    public class CuentaAhorro : Cuenta
    {
        public override string Retirar(decimal monto)
        {
            if (SaldoCuenta >= monto)
            {
                SaldoCuenta -= monto;
            return $"Retiro exitoso (Ahorro). Nuevo saldo: {SaldoCuenta:C2}";
        }

            return "No puedes retirar mas de lo que tienes en tu cuenta de ahorro";
        }
    }
    public class CuentaCorriente : Cuenta
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

