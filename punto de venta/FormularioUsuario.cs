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
    public partial class FormularioUsuario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public FormularioUsuario()
        {
            InitializeComponent();
            DataGrid.DataSource = cn.ConsultaDT();
        }

        private void label3_Click(object sender, EventArgs e) {}

        private void FormularioUsuario_Load(object sender, EventArgs e) {}



        private void B_NuevoUsuario_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()) { }
            else
            {
                cn.InsertarUsuario(Txt_Nombre.Text, Txt_Apellido.Text, Txt_DNI.Text, Txt_Telefono.Text, Txt_Usuario.Text, Txt_Contra.Text);
                Vaciar();
            }
            
        }
        private void B_ModificarUsuario_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()) { }
            else
            {
                cn.ModificarUsuario(Txt_Nombre.Text, Txt_Apellido.Text, Txt_DNI.Text, Txt_Telefono.Text, Txt_Usuario.Text, Txt_Contra.Text);
                Vaciar();
            }
            
            
        }

        private void B_EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_DNI.Text))
            {
                MessageBox.Show("El campo DNI esta vacio");
                return;
            }
            else
            {
                cn.EliminarUsuario(Txt_DNI.Text);
                Vaciar();
            }
            
            
        }




        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        private void ValidarLetas(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void Vaciar()
        {
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_DNI.Text = "";
            Txt_Telefono.Text = "";
            Txt_Usuario.Text = "";
            Txt_Contra.Text = "";
            DataGrid.DataSource = cn.ConsultaDT();
            Txt_Nombre.Focus();
        }

        private bool NoDejarVacio()
        {
            if (String.IsNullOrEmpty(Txt_Apellido.Text) || String.IsNullOrEmpty(Txt_Contra.Text) ||
                String.IsNullOrEmpty(Txt_DNI.Text) || String.IsNullOrEmpty(Txt_Nombre.Text)
                || String.IsNullOrEmpty(Txt_Telefono.Text) || String.IsNullOrEmpty(Txt_Usuario.Text))
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
