using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Data.SqlClient;

namespace CapaDatos 
{

    public class CuentaRepositorio {


        public string conexion = "Server=.;DataBase=CuentaCliente;Integrated Security=true";

        // Obtiene una cuenta por su Id y devuelve un objeto del tipo correcto (Ahorro o Corriente)
        public  Cuenta ObtenerCuentaPorId(int idBusqueda) 
        {

            using (SqlConnection conn = new SqlConnection(conexion)) 
            {
                conn.Open();

                //consulta sql para buscara por id
                string query = "SELECT * FROM CuentaCliente WHERE Id = @Id";

                //sql comando 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idBusqueda); // agregar parametro de busqueda 

                //Ejecutando la consulta 
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {

                    string tipoCuenta = reader ["TipoCuenta"].ToString();
                    Cuenta cuenta;

                    if (tipoCuenta == "Ahorros")
                        cuenta = new CuentaAhorro();

                    else
                        cuenta = new CuentaCorriente();

                    cuenta.Id = Convert.ToInt32(reader["Id"]);
                    cuenta.NumCuenta = reader["NumCuenta"].ToString();
                    cuenta.Nombre = reader["Nombre"].ToString();
                    cuenta.Telefono = reader["Telefono"].ToString();
                    cuenta.DNI = reader["DNI"].ToString();
                    cuenta.Email = reader["Email"].ToString();
                    cuenta.Direccion = reader["Direccion"].ToString();
                    cuenta.TipoCuenta = tipoCuenta;
                    cuenta.SaldoCuenta = Convert.ToDecimal(reader["SaldoCuenta"]);


                    return cuenta;

                }
                return null;
            }
        }

    }
    public class Cuenta
    {
        public int Id { get; set; }
        public string NumCuenta { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string TipoCuenta { get; set; }
        public decimal SaldoCuenta { get; set; }

        public virtual string depositar(decimal monto)
        {
            SaldoCuenta += monto;
            return $"deposito exitoso.Nuevo Saldo {SaldoCuenta}";
        }
        public virtual string Retirar(decimal monto)
        {

            SaldoCuenta -= monto;
            return $"Retiro exitoso. Nuevo saldo: {SaldoCuenta}";
        }
        public string ConsultarSaldo()
        {
            return $"Saldo actual: {SaldoCuenta}";
        }

    }
    public class CuentaAhorro : Cuenta 
    {
        public override string Retirar(decimal monto) 
        {
            if (SaldoCuenta >= monto) 
            {
                SaldoCuenta -= monto;
                return $"Retiro existoso (Ahorro). Nuevo Saldo {SaldoCuenta}";
            }

            return "No puedes retirar mas de lo que tienes en tu cuenta de ahorro";
        }
    }
    public class CuentaCorriente : Cuenta 
    {
        public override string Retirar(decimal monto) {

            if (SaldoCuenta >= monto) { 

                SaldoCuenta -= monto;
                return $"Retiro Exitoso (Ahorro).Nuevo Saldo{SaldoCuenta}";
            }

            return "No puedes retirar más de lo que tienes en tu cuenta de ahorro.";
        }
    }

 }

    