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
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;
        ConexionSQLN cn = new ConexionSQLN();
        private double SubTotal = 0;
        private double Total = 0;
        private double Descuento = 0;

        public VentanaPrincipal()
        {
            InitializeComponent();

            Txt_ImpuestosVenta.Text = Txt_ImpuestosEdit.Text;
            Txt_Descuento.Text = Txt_DescuentosEdit.Text;

            

            dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("Nombre producto"); 
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio total");
            GridView.DataSource = dt;

            Txt_NumFactura.Text = cn.ConsultaNumFactura();

        }

        

        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B_Menu_Usuario_Click(object sender, EventArgs e)
        {
            FormularioUsuario v1 = new FormularioUsuario();
            this.Hide();
            v1.ShowDialog();
            this.Show();

        }

        private void inverntarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario v2 = new Inventario();
            this.Hide();
            v2.ShowDialog();
            this.Show();
        }

        
        private void Actualizar_impuestos_Y_Ventas(object sender, EventArgs e)
        {
            Txt_ImpuestosVenta.Text = Txt_ImpuestosEdit.Text;

            if (double.Parse(Txt_DescuentosEdit.Text) >= Descuento)
            {
                Txt_Descuento.Text = Txt_DescuentosEdit.Text;
            }
            else if (double.Parse(Txt_DescuentosEdit.Text) < Descuento)
            {
                Txt_Descuento.Text = Descuento.ToString();
            }
            
            
        }

        private void B_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (NoDejarVacio()) { }
            else
            {
                var resultado = cn.ConsultaProductos(Txt_CodProducto.Text);
                DataRow row = dt.NewRow();
                row["codigo"] = Txt_CodProducto.Text;
                row["Nombre producto"] = resultado.Item1;
                row["Precio Unitario"] = resultado.Item2;
                row["Cantidad"] = Txt_Cantidad.Text;
                row["Precio total"] = Int32.Parse(Txt_Cantidad.Text) * double.Parse(resultado.Item2);

                dt.Rows.Add(row);



                SubTotal = SubTotal + (Int32.Parse(Txt_Cantidad.Text) * double.Parse(resultado.Item2));



                if (double.Parse(Txt_DescuentosEdit.Text) >= Descuento)
                {
                    Total = SubTotal + (SubTotal * (double.Parse(Txt_ImpuestosEdit.Text) / 100)) - (SubTotal * (double.Parse(Txt_DescuentosEdit.Text) / 100));
                }
                else if (double.Parse(Txt_DescuentosEdit.Text) < Descuento)
                {
                    Total = SubTotal + (SubTotal * (double.Parse(Txt_ImpuestosEdit.Text) / 100)) - (SubTotal * (Descuento / 100));
                }


                L_SubTotal.Text = SubTotal.ToString();
                L_Total.Text = Total.ToString();
                Vaciar();
            }
            


        }

        private void B_CodCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_CodCliente.Text))
            {
                MessageBox.Show("El campo Codigo Cliente esta vacio");
                return;
            }
            else
            {
                var resultado2 = cn.ConsultaClientes(Txt_CodCliente.Text);
                Txt_Cliente.Text = resultado2.Item1;
                Descuento = resultado2.Item2;

                if (double.Parse(Txt_DescuentosEdit.Text) >= Descuento)
                {
                    Txt_Descuento.Text = Txt_DescuentosEdit.Text;
                }
                else if (double.Parse(Txt_DescuentosEdit.Text) < Descuento)
                {
                    Txt_Descuento.Text = Descuento.ToString();
                }
            }
            
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void B_Facturar_Click(object sender, EventArgs e)
        {
            
            List<Factura> listfact = new List<Factura>();
            foreach (DataRow row in dt.Rows)
            {
                Factura fact = new Factura();

                fact.Codigo = row["codigo"].ToString();
                fact.Producto = row["Nombre producto"].ToString();
                fact.PrecioXUnidad = row["Precio Unitario"].ToString();
                fact.Cantidad = row["Cantidad"].ToString();
                fact.PrecioTotal = row["Precio total"].ToString();
                fact.Descuento = Txt_Descuento.Text;
                fact.Cliente = Txt_Cliente.Text;
                fact.NumFact= Txt_NumFactura.Text;

                listfact.Add(fact);

            }

            cn.GuardarFactura(listfact);


            Txt_NumFactura.Text = cn.ConsultaNumFactura();


            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

            Limpiar();

        }


        private void Limpiar()
        {
            Txt_Cliente.Text = "";
            Txt_CodCliente.Text = "";
            Txt_Descuento.Text = Txt_DescuentosEdit.Text;
            L_SubTotal.Text = "0,00";
            L_Total.Text = "0,00";
            dt.Clear();
        }

        private void Vaciar()
        {
            Txt_CodProducto.Text = "";
            Txt_Cantidad.Text = "";
            Txt_CodProducto.Focus();
        }


        





        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int x = 300;
            int y = 20;
            e.Graphics.DrawString("--Aca se vende de tó---", font, Brushes.Black, new RectangleF(0, y+=20,x,20));
            e.Graphics.DrawString("N° de Factura"+ Txt_NumFactura.Text, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("Cliente: "+ Txt_Cliente.Text  , font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("--Detalles de la compra---", font, Brushes.Black, new RectangleF(0, y += 20, x, 20));


            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["codigo"].ToString() + " " + 
                    row["Nombre producto"].ToString() + " " + 
                    row["Precio total"].ToString() 
                    , font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            }

            e.Graphics.DrawString("Subtotal: " + L_SubTotal.Text, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));
            e.Graphics.DrawString("Total: " + L_Total.Text, font, Brushes.Black, new RectangleF(0, y += 20, x, 20));

        }

        private bool NoDejarVacio()
        {
            if (String.IsNullOrEmpty(Txt_CodProducto.Text) || String.IsNullOrEmpty(Txt_Cantidad.Text))
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
