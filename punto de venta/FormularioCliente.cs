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
    public partial class FormularioCliente : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public FormularioCliente()
        {
            InitializeComponent();
            DataGrid.DataSource = cn.ConsultaDT();
        }


        private void FormularioUsuario_Load(object sender, EventArgs e) {}



        private void B_NuevoUsuario_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()) { }
            else
            {
                if (Convert.ToInt32(Txt_DescCliente.Text)<=100)
                {
                    int Verificar = cn.InsertarCliente(Txt_Nombre.Text, Txt_Apellido.Text, Txt_CodCliente.Text, Txt_DescCliente.Text, Txt_Correo.Text);
                    if (Verificar == 0)
                    {
                        MessageBox.Show("El codgigo " + Txt_CodCliente.Text + " ya esta en uso");
                    }
                    else{Vaciar();}
                }
                else { MessageBox.Show("Coloque un descuento razonable");}   
            } 
        }
        private void B_ModificarUsuario_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()) { }
            else
            {
                if (Convert.ToInt32(Txt_DescCliente.Text) <= 100)
                {
                    cn.ModificarCliente(Txt_Nombre.Text, Txt_Apellido.Text, Txt_CodCliente.Text, Txt_DescCliente.Text, Txt_Correo.Text);
                    Vaciar();
                }
                else { MessageBox.Show("Coloque un descuento razonable"); }
            }    
        }

        private void B_EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_CodCliente.Text))
            {
                MessageBox.Show("El campo Codigo Cliente esta vacio");
                return;
            }
            else
            {
                cn.EliminarCliente(Txt_CodCliente.Text);
                Vaciar();
            }
            
            
        }




        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
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
            Txt_CodCliente.Text = "";
            Txt_DescCliente.Text = "";
            Txt_Correo.Text = "";

            DataGrid.DataSource = cn.ConsultaDT();
            Txt_Nombre.Focus();
        }

        private bool NoDejarVacio()
        {
            if (String.IsNullOrEmpty(Txt_Apellido.Text)  ||
                String.IsNullOrEmpty(Txt_CodCliente.Text) || String.IsNullOrEmpty(Txt_Nombre.Text)
                || String.IsNullOrEmpty(Txt_DescCliente.Text) || String.IsNullOrEmpty(Txt_Correo.Text))
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
