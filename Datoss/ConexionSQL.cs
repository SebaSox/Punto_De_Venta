using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace Datoss
{
    public class ConexionSQL
    {
        static string server = "SEBASOX";
        static string conexionstring = "server= " + server + "; database= PuntoDeVenta;" +
            "integrated security =true;";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario, string Contra)
        {
            int count;
            con.Open();

            string Query = "Select Count(*) FROM persona where Usuario ='" + Usuario + "'" +
                "and Contra = '" + Contra + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count;

        }


        public DataTable ConsultaClienteDataGrid()
        {
            string query = "select * from Cliente";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter Data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            Data.Fill(tabla);
            return tabla;
        }


        public int InsertarCliente(string Nom, string Ape, string CodCli, string DescCli, string Correo)
        {
            int Bandera = 0;
            con.Open();
            string query = "insert into Cliente values ('" + Nom + "','" + Ape + "','" + CodCli + "','" + DescCli + "','" + Correo + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            Bandera = cmd.ExecuteNonQuery();
            con.Close();
            return Bandera;
        }
        public int ModificarCliente(string Nom, string Ape, string CodCli, string DescCli, string Correo)
        {
            int Bandera = 0;
            con.Open();
            string query = "Update Cliente set Nombre ='" + Nom + "', Apellido = '" + Ape + "', CodigoCliente = '" + CodCli + "', DescuentoCliente = '" + DescCli + "', Correo = '" + Correo  + "' Where CodigoCliente ='" + CodCli + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            Bandera = cmd.ExecuteNonQuery();
            con.Close();
            return Bandera;
        }

        public int EliminarCliente(string CodCli)
        {
            int Bandera = 0;
            con.Open();
            string query = "Delete from Cliente Where CodigoCliente ='" + CodCli + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            Bandera = cmd.ExecuteNonQuery();
            con.Close();
            return Bandera;
        }

        public string ConsultaNumFactura()
        {

            con.Open();
            string resultado = "null";
            string query = "Select (Select distinct top 1 NumFactura from Facturacion order by NumFactura desc) +1 as NumeroFactura";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (""!=reg["NumeroFactura"].ToString())
                {
                    resultado = reg["NumeroFactura"].ToString();
                }
                else
                {
                    resultado = "0";
                }

            }
            con.Close();
            return resultado;
        }

        public Tuple<string, string> ConsultaProductos(string codigo)
        {
            con.Open();
            string resultado = "null";
            string resultado1 = "null";
            string query = "Select * from Inventario where Codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {

                resultado = reg["Producto"].ToString();
                resultado1 = reg["PrecioU"].ToString();


            }

            con.Close();
            return Tuple.Create(resultado, resultado1);
        }
        public Tuple<string, double> ConsultaClientes(string codigo)
        {
            con.Open();
            string resultado = "null";
            double resultado1 = 0;
            string query = "select CONCAT([Nombre],' ', [Apellido]) as NombreCompleto, [DescuentoCliente] from Cliente where [CodigoCliente] =1;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {

                resultado = reg["NombreCompleto"].ToString();
                resultado1 = double.Parse(reg["DescuentoCliente"].ToString());
            }

            con.Close();
            return Tuple.Create(resultado, resultado1);
        }


        public void GuardarFactura(List<Factura> F)
        {
            con.Open();
            foreach (Factura fact in F)
            {
                string query = "insert into facturacion values ('" + fact.Codigo + "','" + fact.Producto + "','" + 
                    fact.PrecioXUnidad + "','" + fact.Cantidad + "','" + fact.PrecioTotal + "','" + fact.Descuento + 
                    "','" + fact.CodCliente + "','" + fact.NumFact + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }

            con.Close();


        }


        //Inventario 

        public DataTable ConsultaInventarioDataGrid()
        {
            string query = "select Codigo, Producto, Categoria, PrecioU from Inventario order by Codigo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter Data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            Data.Fill(tabla);
            return tabla;
        }


        public int InsertarProducto(string Cod, string Prod, string Cat, string Pre)
        {
            int Bandera = 0;
            con.Open();
            string query = "insert into Inventario values ('" + Prod + "','" + Cat + "','" + Pre + "','" + "" + "','" + Cod + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            Bandera = cmd.ExecuteNonQuery();
            con.Close();
            return Bandera;
        }
        public int ModificarProducto(string Cod, string Prod, string Cat, string Pre)
        {
            int Bandera = 0;
            con.Open();
            string query = "Update Inventario set Producto ='" + Prod + "', Categoria = '" + Cat + "', PrecioU = '" + Pre + "', Cantidad = '" + "" + "', Codigo = '" + Cod + "' Where Codigo ='" + Cod + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            Bandera = cmd.ExecuteNonQuery();
            con.Close();
            return Bandera;
        }

        public int EliminarProducto(string Cod)
        {
            int Bandera = 0;
            con.Open();
            string query = "Delete from Inventario Where Codigo ='" + Cod + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            Bandera = cmd.ExecuteNonQuery();
            con.Close();
            return Bandera;
        }

        //Historial
        public DataTable BuscarFactura(string NF)
        {
            string query = "select Codigo, Producto as 'Nombre Producto', Precioxunidad as 'Precio x Unidad', Cantidad, precioTotal as 'Precio total', Descuento, CodigoCliente as 'Codigo Cliente' from Facturacion where NumFactura= '" + NF + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter Data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            Data.Fill(tabla);
            return tabla;
        }

        public int SumarTotal(string NF)
        {
            int Bandera;
            con.Open();
            string query = "select SUM(precioTotal) as 'PrecioTotal'  from Facturacion where NumFactura= '" + NF + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                Bandera = Convert.ToInt32(reg["PrecioTotal"]);


            }
            else
            {
                Bandera = 0;
            }
            
            con.Close();
            return Bandera;
        }




    }
}
