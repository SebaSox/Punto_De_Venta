using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocioss;


namespace punto_de_venta
{
    


    public partial class Inventario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private DataTable dt;
        public Inventario()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre producto");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("Precio");
            GridViewInventario.DataSource = dt;
            GridViewInventario.DataSource = cn.ConsultaDTInventario();


        }

        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

     
        private void B_Anadir_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()){}
            else
            {
                cn.InsertarProducto(Txt_CodigoProd.Text, Txt_producto.Text, Txt_Categoria.Text, Txt_Precio.Text);
                Vaciar();
            }


            
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()){}
            else
            {
                cn.ModificarProducto(Txt_CodigoProd.Text, Txt_producto.Text, Txt_Categoria.Text, Txt_Precio.Text);
                Vaciar();
            }
            
            
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Txt_CodigoProd.Text))
            {
                MessageBox.Show("El campo codigo esta vacio");
                return;
            }
            else
            {
                cn.EliminarProducto(Txt_CodigoProd.Text);
                Vaciar();
            } 

            
        }

        private void Vaciar()
        {
            Txt_Categoria.Text = "";
            Txt_CodigoProd.Text = "";
            Txt_Precio.Text = "";
            Txt_producto.Text = "";
            GridViewInventario.DataSource = cn.ConsultaDTInventario();
            Txt_CodigoProd.Focus();
        }

        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        private void ValidarLetas(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private bool NoDejarVacio()
        {
            if (String.IsNullOrEmpty(Txt_CodigoProd.Text) || String.IsNullOrEmpty(Txt_producto.Text) ||
                String.IsNullOrEmpty(Txt_Categoria.Text) || String.IsNullOrEmpty(Txt_Precio.Text))
            {
                MessageBox.Show("Uno o mas de los campos esta vacio");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
