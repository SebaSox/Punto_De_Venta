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
            
            cn.InsertarUsuario(Txt_Nombre.Text, Txt_Apellido.Text, Txt_DNI.Text, Txt_Telefono.Text, Txt_Usuario.Text, Txt_Contra.Text);
            DataGrid.DataSource = cn.ConsultaDT();
        }
        private void B_ModificarUsuario_Click(object sender, EventArgs e)
        {
            cn.ModificarUsuario(Txt_Nombre.Text, Txt_Apellido.Text, Txt_DNI.Text, Txt_Telefono.Text, Txt_Usuario.Text, Txt_Contra.Text);

            DataGrid.DataSource = cn.ConsultaDT();
        }

        private void B_EliminarUsuario_Click(object sender, EventArgs e)
        {
            cn.EliminarUsuario(Txt_DNI.Text);
            DataGrid.DataSource = cn.ConsultaDT();
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
    }
}
