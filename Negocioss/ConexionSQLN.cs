using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datoss;
using Entidades;

namespace Negocioss
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }

        

        //Factura

        public string ConsultaNumFactura()
        {
            return cn.ConsultaNumFactura(); 
        }

        public Tuple<string, string> ConsultaProductos(string codigo)
        {
            return cn.ConsultaProductos(codigo);
        }
        public Tuple<string, double> ConsultaClientes(string codigo)
        {
            return cn.ConsultaClientes(codigo);
        }


        public void GuardarFactura(List<Factura> F)
        {
            cn.GuardarFactura(F);
        }




        //Cliente
        public DataTable ConsultaDT()
        {

            return cn.ConsultaClienteDataGrid();

        }
        public int InsertarCliente(string Nom, string Ape, string CodCli, string DescCli, string Correo)
        {
            return cn.InsertarCliente(Nom, Ape, CodCli, DescCli, Correo);
        }
        public int ModificarCliente(string Nom, string Ape, string CodCli, string DescCli, string Correo)
        {
            return cn.ModificarCliente(Nom, Ape, CodCli, DescCli, Correo);
        }

        public int EliminarCliente(string CodCli)
        {
            return cn.EliminarCliente(CodCli);
        }



        //Inventario

        public DataTable ConsultaDTInventario()
        {
            return cn.ConsultaInventarioDataGrid();
        }
        public int InsertarProducto(string Cod, string Prod, string Cat, string Pre)
        {
            return cn.InsertarProducto(Cod, Prod, Cat, Pre);
        }
        public int ModificarProducto(string Cod, string Prod, string Cat, string Pre)
        {
            return cn.ModificarProducto(Cod, Prod, Cat, Pre);
        }
        public int EliminarProducto(string Cod)
        {
            return cn.EliminarProducto(Cod);
        }



        //Historial

        public DataTable BuscarFactura(string NF)
        {
            return cn.BuscarFactura(NF);
        }

        public int SumarTotal(string NF)
        {
            return cn.SumarTotal(NF);
        }
        public Tuple<string, double> ConsultaClientesHistorial(string codigo)
        {
            return cn.ConsultaClientesHistorial(codigo);
        }

    }
}
