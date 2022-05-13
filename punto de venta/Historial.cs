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
    public partial class Historial : Form
    {
        private DataTable dt;
        ConexionSQLN cn = new ConexionSQLN();
        public Historial()
        {
            InitializeComponent();
        }

        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void B_BuscarHistorial_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Buscar.Text))
            {
                MessageBox.Show("El campo Codigo Cliente esta vacio");
                return;
            }
            else
            {
                
                dataGridHistorial.DataSource = dt;
                dataGridHistorial.DataSource = cn.BuscarFactura(Txt_Buscar.Text);


                var datos = cn.ConsultaClientes(Txt_Buscar.Text);
                
                L_Cliente.Text = datos.Item1;


                
                L_Total.Text = (Convert.ToInt32(cn.SumarTotal(Txt_Buscar.Text)) * (datos.Item2 /100)).ToString();
            }

            

        }
    }
}
