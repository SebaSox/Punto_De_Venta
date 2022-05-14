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
using Entidades;
using System.Drawing.Printing;

namespace punto_de_venta
{
    public partial class Historial : Form
    {
        int SubTotal;
        private DataTable dt;
        ConexionSQLN cn = new ConexionSQLN();
        public Historial()
        {
            InitializeComponent();
            CrearTabla();
            
        }
        //Botones
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

                var id = dataGridHistorial.Rows[0].Cells[6].Value.ToString();
                var datos = cn.ConsultaClientesHistorial(id);
                L_Cliente.Text = datos.Item1;
                SubTotal = cn.SumarTotal(Txt_Buscar.Text);
                L_Total.Text = (Convert.ToInt32(SubTotal) * (datos.Item2 /100)).ToString();

                B_Imprimir.Enabled = true;
            }

        }

        private void B_Imprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.DocumentName = "Factura N°" + Txt_Buscar;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

            Limpiar();

        }

        //Metodos

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int x = 600;
            int y = 20;
            e.Graphics.DrawString("--Aca se vende de tó---", font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("N° de Factura:  " + Txt_Buscar.Text, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("Cliente: " + L_Cliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("---Detalles de la compra---", font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("Codigo | Producto | Precio Uni | Cantidad | Total Prodcuto", font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            for (int i = 0; i < dataGridHistorial.RowCount-1; i++)
            {
                e.Graphics.DrawString("-" +dataGridHistorial.Rows[i].Cells[0].Value.ToString() + " " +
                    dataGridHistorial.Rows[i].Cells[1].Value.ToString() + " " +
                    dataGridHistorial.Rows[i].Cells[2].Value.ToString() + " " +
                    dataGridHistorial.Rows[i].Cells[3].Value.ToString() + " " +
                    dataGridHistorial.Rows[i].Cells[4].Value.ToString()
                    , font, Brushes.Black, new RectangleF(5, y += 20, x, 20));
        }

            e.Graphics.DrawString("Subtotal: " + SubTotal, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("Total: " + L_Total.Text, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));

        }

        private void Limpiar()
        {
            Txt_Buscar.Text = "";
            Txt_Buscar.Focus();
            L_Cliente.Text = "0";
            L_Total.Text = "0";
            dataGridHistorial.DataSource = null;
            B_Imprimir.Enabled = false;
            CrearTabla();

        }
        private void CrearTabla()
        {
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre producto");
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio total");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Codigo Cliente");
            dataGridHistorial.DataSource = dt;
        }
    }
}
