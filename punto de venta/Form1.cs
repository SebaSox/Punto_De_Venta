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
    public partial class Form1 : Form
    {

        ConexionSQLN cn = new ConexionSQLN();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B_Entrar_Click(object sender, EventArgs e)
        {


            //if (cn.conSQL(Txt_Usuario.Text, Txt_Contra.Text) == 1)
            //{
            //    MessageBox.Show("el usuario fue encontrado");

            //    this.Hide();
            //    VentanaPrincipal v1 = new VentanaPrincipal();
            //    v1.Show();

            //}
            //else
            //{
            //    MessageBox.Show("el usuario NO fue encontrado");
            //}

            this.Hide();
            VentanaPrincipal v1 = new VentanaPrincipal();
            v1.Show();
        }
    }
}
