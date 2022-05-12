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

        public DataTable ConsultaDT()
        {

            return cn.ConsultaUsuariosDataGrid();

        }

        public int InsertarUsuario(string Nom, string Ape, string Dni, string TEL, string User, string Con)
        {
            return cn.InsertarUsuario(Nom,Ape,Dni,TEL,User,Con);
        }
        public int ModificarUsuario(string Nom, string Ape, string Dni, string TEL, string User, string Con)
        {
            return cn.ModificarUsuario(Nom, Ape, Dni, TEL, User, Con);
        }

        public int EliminarUsuario(string Dni)
        {
            return cn.EliminarUsuario(Dni);
        }

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
    }
}
