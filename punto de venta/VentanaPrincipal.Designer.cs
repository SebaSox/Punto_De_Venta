
namespace punto_de_venta
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.B_Menu_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosYDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_ImpuestosEdit = new System.Windows.Forms.ToolStripTextBox();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_DescuentosEdit = new System.Windows.Forms.ToolStripTextBox();
            this.B_Menu_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.inverntarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.L_CodCliente = new System.Windows.Forms.Label();
            this.L_NuFactura = new System.Windows.Forms.Label();
            this.L_Cliente = new System.Windows.Forms.Label();
            this.L_SubTotalTxt = new System.Windows.Forms.Label();
            this.L_SubTotal = new System.Windows.Forms.Label();
            this.L_ImpuestosVenta = new System.Windows.Forms.Label();
            this.L_Descuento = new System.Windows.Forms.Label();
            this.L_TotalTxt = new System.Windows.Forms.Label();
            this.L_CodProducto = new System.Windows.Forms.Label();
            this.L_Cantidad = new System.Windows.Forms.Label();
            this.B_CodCliente = new System.Windows.Forms.Button();
            this.B_AgregarProducto = new System.Windows.Forms.Button();
            this.B_Facturar = new System.Windows.Forms.Button();
            this.Txt_NumFactura = new System.Windows.Forms.TextBox();
            this.Txt_CodCliente = new System.Windows.Forms.TextBox();
            this.Txt_ImpuestosVenta = new System.Windows.Forms.TextBox();
            this.Txt_Descuento = new System.Windows.Forms.TextBox();
            this.Txt_CodProducto = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.L_Total = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Cerrar
            // 
            this.B_Cerrar.Location = new System.Drawing.Point(969, 499);
            this.B_Cerrar.Name = "B_Cerrar";
            this.B_Cerrar.Size = new System.Drawing.Size(162, 48);
            this.B_Cerrar.TabIndex = 0;
            this.B_Cerrar.Text = "CERRAR";
            this.B_Cerrar.UseVisualStyleBackColor = true;
            this.B_Cerrar.Click += new System.EventHandler(this.B_Cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.B_Menu_Archivo,
            this.B_Menu_Usuario,
            this.inverntarioToolStripMenuItem,
            this.historiaDeVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // B_Menu_Archivo
            // 
            this.B_Menu_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestosYDescuentosToolStripMenuItem});
            this.B_Menu_Archivo.Name = "B_Menu_Archivo";
            this.B_Menu_Archivo.Size = new System.Drawing.Size(73, 24);
            this.B_Menu_Archivo.Text = "Archivo";
            // 
            // impuestosYDescuentosToolStripMenuItem
            // 
            this.impuestosYDescuentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestosToolStripMenuItem,
            this.descuentosToolStripMenuItem});
            this.impuestosYDescuentosToolStripMenuItem.Name = "impuestosYDescuentosToolStripMenuItem";
            this.impuestosYDescuentosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.impuestosYDescuentosToolStripMenuItem.Text = "Impuestos y Descuentos";
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_ImpuestosEdit});
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.impuestosToolStripMenuItem.Text = "Impuestos:";
            // 
            // Txt_ImpuestosEdit
            // 
            this.Txt_ImpuestosEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_ImpuestosEdit.Name = "Txt_ImpuestosEdit";
            this.Txt_ImpuestosEdit.Size = new System.Drawing.Size(100, 27);
            this.Txt_ImpuestosEdit.Text = "21";
            this.Txt_ImpuestosEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            this.Txt_ImpuestosEdit.TextChanged += new System.EventHandler(this.Actualizar_impuestos_Y_Ventas);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_DescuentosEdit});
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.descuentosToolStripMenuItem.Text = "Descuentos:";
            // 
            // Txt_DescuentosEdit
            // 
            this.Txt_DescuentosEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_DescuentosEdit.Name = "Txt_DescuentosEdit";
            this.Txt_DescuentosEdit.Size = new System.Drawing.Size(100, 27);
            this.Txt_DescuentosEdit.Text = "5";
            this.Txt_DescuentosEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            this.Txt_DescuentosEdit.TextChanged += new System.EventHandler(this.Actualizar_impuestos_Y_Ventas);
            // 
            // B_Menu_Usuario
            // 
            this.B_Menu_Usuario.Name = "B_Menu_Usuario";
            this.B_Menu_Usuario.Size = new System.Drawing.Size(73, 24);
            this.B_Menu_Usuario.Text = "Usuario";
            this.B_Menu_Usuario.Click += new System.EventHandler(this.B_Menu_Usuario_Click);
            // 
            // inverntarioToolStripMenuItem
            // 
            this.inverntarioToolStripMenuItem.Name = "inverntarioToolStripMenuItem";
            this.inverntarioToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.inverntarioToolStripMenuItem.Text = "Inverntario";
            this.inverntarioToolStripMenuItem.Click += new System.EventHandler(this.inverntarioToolStripMenuItem_Click);
            // 
            // historiaDeVentasToolStripMenuItem
            // 
            this.historiaDeVentasToolStripMenuItem.Name = "historiaDeVentasToolStripMenuItem";
            this.historiaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.historiaDeVentasToolStripMenuItem.Text = "Historia de Ventas";
            this.historiaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.historiaDeVentasToolStripMenuItem_Click);
            // 
            // L_CodCliente
            // 
            this.L_CodCliente.AutoSize = true;
            this.L_CodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_CodCliente.Location = new System.Drawing.Point(14, 217);
            this.L_CodCliente.Name = "L_CodCliente";
            this.L_CodCliente.Size = new System.Drawing.Size(138, 20);
            this.L_CodCliente.TabIndex = 3;
            this.L_CodCliente.Text = "Codigo Cliente:";
            // 
            // L_NuFactura
            // 
            this.L_NuFactura.AutoSize = true;
            this.L_NuFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_NuFactura.Location = new System.Drawing.Point(174, 43);
            this.L_NuFactura.Name = "L_NuFactura";
            this.L_NuFactura.Size = new System.Drawing.Size(106, 20);
            this.L_NuFactura.TabIndex = 4;
            this.L_NuFactura.Text = "N° Factura:";
            // 
            // L_Cliente
            // 
            this.L_Cliente.AutoSize = true;
            this.L_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cliente.Location = new System.Drawing.Point(727, 43);
            this.L_Cliente.Name = "L_Cliente";
            this.L_Cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_Cliente.Size = new System.Drawing.Size(74, 20);
            this.L_Cliente.TabIndex = 8;
            this.L_Cliente.Text = "Cliente:";
            // 
            // L_SubTotalTxt
            // 
            this.L_SubTotalTxt.AutoSize = true;
            this.L_SubTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_SubTotalTxt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.L_SubTotalTxt.Location = new System.Drawing.Point(14, 373);
            this.L_SubTotalTxt.Name = "L_SubTotalTxt";
            this.L_SubTotalTxt.Size = new System.Drawing.Size(95, 20);
            this.L_SubTotalTxt.TabIndex = 6;
            this.L_SubTotalTxt.Text = "Sub Total:";
            // 
            // L_SubTotal
            // 
            this.L_SubTotal.AutoSize = true;
            this.L_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SubTotal.Location = new System.Drawing.Point(23, 410);
            this.L_SubTotal.Name = "L_SubTotal";
            this.L_SubTotal.Size = new System.Drawing.Size(122, 55);
            this.L_SubTotal.TabIndex = 7;
            this.L_SubTotal.Text = "0,00";
            // 
            // L_ImpuestosVenta
            // 
            this.L_ImpuestosVenta.AutoSize = true;
            this.L_ImpuestosVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_ImpuestosVenta.Location = new System.Drawing.Point(227, 353);
            this.L_ImpuestosVenta.Name = "L_ImpuestosVenta";
            this.L_ImpuestosVenta.Size = new System.Drawing.Size(152, 20);
            this.L_ImpuestosVenta.TabIndex = 8;
            this.L_ImpuestosVenta.Text = "Impuestos venta:";
            // 
            // L_Descuento
            // 
            this.L_Descuento.AutoSize = true;
            this.L_Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_Descuento.Location = new System.Drawing.Point(227, 391);
            this.L_Descuento.Name = "L_Descuento";
            this.L_Descuento.Size = new System.Drawing.Size(105, 20);
            this.L_Descuento.TabIndex = 9;
            this.L_Descuento.Text = "Descuento:";
            // 
            // L_TotalTxt
            // 
            this.L_TotalTxt.AutoSize = true;
            this.L_TotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TotalTxt.Location = new System.Drawing.Point(226, 425);
            this.L_TotalTxt.Name = "L_TotalTxt";
            this.L_TotalTxt.Size = new System.Drawing.Size(80, 29);
            this.L_TotalTxt.TabIndex = 10;
            this.L_TotalTxt.Text = "Total:";
            // 
            // L_CodProducto
            // 
            this.L_CodProducto.AutoSize = true;
            this.L_CodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_CodProducto.Location = new System.Drawing.Point(583, 350);
            this.L_CodProducto.Name = "L_CodProducto";
            this.L_CodProducto.Size = new System.Drawing.Size(152, 20);
            this.L_CodProducto.TabIndex = 12;
            this.L_CodProducto.Text = "Codigo producto:";
            // 
            // L_Cantidad
            // 
            this.L_Cantidad.AutoSize = true;
            this.L_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.L_Cantidad.Location = new System.Drawing.Point(814, 350);
            this.L_Cantidad.Name = "L_Cantidad";
            this.L_Cantidad.Size = new System.Drawing.Size(89, 20);
            this.L_Cantidad.TabIndex = 13;
            this.L_Cantidad.Text = "Cantidad:";
            // 
            // B_CodCliente
            // 
            this.B_CodCliente.Location = new System.Drawing.Point(18, 286);
            this.B_CodCliente.Name = "B_CodCliente";
            this.B_CodCliente.Size = new System.Drawing.Size(134, 42);
            this.B_CodCliente.TabIndex = 14;
            this.B_CodCliente.Text = "Buscar Cliente";
            this.B_CodCliente.UseVisualStyleBackColor = true;
            this.B_CodCliente.Click += new System.EventHandler(this.B_CodCliente_Click);
            // 
            // B_AgregarProducto
            // 
            this.B_AgregarProducto.Location = new System.Drawing.Point(616, 406);
            this.B_AgregarProducto.Name = "B_AgregarProducto";
            this.B_AgregarProducto.Size = new System.Drawing.Size(317, 75);
            this.B_AgregarProducto.TabIndex = 15;
            this.B_AgregarProducto.Text = "Agregar producto";
            this.B_AgregarProducto.UseVisualStyleBackColor = true;
            this.B_AgregarProducto.Click += new System.EventHandler(this.B_AgregarProducto_Click);
            // 
            // B_Facturar
            // 
            this.B_Facturar.Location = new System.Drawing.Point(969, 366);
            this.B_Facturar.Name = "B_Facturar";
            this.B_Facturar.Size = new System.Drawing.Size(163, 115);
            this.B_Facturar.TabIndex = 16;
            this.B_Facturar.Text = "Facturar";
            this.B_Facturar.UseVisualStyleBackColor = true;
            this.B_Facturar.Click += new System.EventHandler(this.B_Facturar_Click);
            // 
            // Txt_NumFactura
            // 
            this.Txt_NumFactura.Location = new System.Drawing.Point(299, 43);
            this.Txt_NumFactura.Name = "Txt_NumFactura";
            this.Txt_NumFactura.ReadOnly = true;
            this.Txt_NumFactura.Size = new System.Drawing.Size(276, 22);
            this.Txt_NumFactura.TabIndex = 17;
            // 
            // Txt_CodCliente
            // 
            this.Txt_CodCliente.Location = new System.Drawing.Point(18, 240);
            this.Txt_CodCliente.Name = "Txt_CodCliente";
            this.Txt_CodCliente.Size = new System.Drawing.Size(134, 22);
            this.Txt_CodCliente.TabIndex = 19;
            this.Txt_CodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_ImpuestosVenta
            // 
            this.Txt_ImpuestosVenta.Location = new System.Drawing.Point(397, 353);
            this.Txt_ImpuestosVenta.Name = "Txt_ImpuestosVenta";
            this.Txt_ImpuestosVenta.ReadOnly = true;
            this.Txt_ImpuestosVenta.Size = new System.Drawing.Size(100, 22);
            this.Txt_ImpuestosVenta.TabIndex = 20;
            // 
            // Txt_Descuento
            // 
            this.Txt_Descuento.Location = new System.Drawing.Point(397, 391);
            this.Txt_Descuento.Name = "Txt_Descuento";
            this.Txt_Descuento.ReadOnly = true;
            this.Txt_Descuento.Size = new System.Drawing.Size(100, 22);
            this.Txt_Descuento.TabIndex = 21;
            // 
            // Txt_CodProducto
            // 
            this.Txt_CodProducto.Location = new System.Drawing.Point(586, 373);
            this.Txt_CodProducto.Name = "Txt_CodProducto";
            this.Txt_CodProducto.Size = new System.Drawing.Size(156, 22);
            this.Txt_CodProducto.TabIndex = 22;
            this.Txt_CodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(818, 373);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(145, 22);
            this.Txt_Cantidad.TabIndex = 23;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // GridView
            // 
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(169, 76);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(963, 252);
            this.GridView.TabIndex = 24;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(807, 43);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.ReadOnly = true;
            this.Txt_Cliente.Size = new System.Drawing.Size(324, 22);
            this.Txt_Cliente.TabIndex = 25;
            // 
            // L_Total
            // 
            this.L_Total.AutoSize = true;
            this.L_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Total.Location = new System.Drawing.Point(264, 456);
            this.L_Total.Name = "L_Total";
            this.L_Total.Size = new System.Drawing.Size(197, 91);
            this.L_Total.TabIndex = 26;
            this.L_Total.Text = "0,00";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::punto_de_venta.Properties.Resources.GENERICA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 556);
            this.Controls.Add(this.L_Total);
            this.Controls.Add(this.Txt_Cliente);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Txt_CodProducto);
            this.Controls.Add(this.Txt_Descuento);
            this.Controls.Add(this.Txt_ImpuestosVenta);
            this.Controls.Add(this.Txt_CodCliente);
            this.Controls.Add(this.Txt_NumFactura);
            this.Controls.Add(this.B_Facturar);
            this.Controls.Add(this.B_AgregarProducto);
            this.Controls.Add(this.B_CodCliente);
            this.Controls.Add(this.L_Cantidad);
            this.Controls.Add(this.L_CodProducto);
            this.Controls.Add(this.L_TotalTxt);
            this.Controls.Add(this.L_Descuento);
            this.Controls.Add(this.L_ImpuestosVenta);
            this.Controls.Add(this.L_SubTotal);
            this.Controls.Add(this.L_SubTotalTxt);
            this.Controls.Add(this.L_Cliente);
            this.Controls.Add(this.L_NuFactura);
            this.Controls.Add(this.L_CodCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1171, 603);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1171, 603);
            this.Name = "VentanaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VentanaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem B_Menu_Archivo;
        private System.Windows.Forms.ToolStripMenuItem B_Menu_Usuario;
        private System.Windows.Forms.ToolStripMenuItem inverntarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_CodCliente;
        private System.Windows.Forms.Label L_NuFactura;
        private System.Windows.Forms.Label L_Cliente;
        private System.Windows.Forms.Label L_SubTotalTxt;
        private System.Windows.Forms.Label L_SubTotal;
        private System.Windows.Forms.Label L_ImpuestosVenta;
        private System.Windows.Forms.Label L_Descuento;
        private System.Windows.Forms.Label L_TotalTxt;
        private System.Windows.Forms.Label L_CodProducto;
        private System.Windows.Forms.Label L_Cantidad;
        private System.Windows.Forms.Button B_CodCliente;
        private System.Windows.Forms.Button B_AgregarProducto;
        private System.Windows.Forms.Button B_Facturar;
        private System.Windows.Forms.TextBox Txt_NumFactura;
        private System.Windows.Forms.TextBox Txt_CodCliente;
        private System.Windows.Forms.TextBox Txt_ImpuestosVenta;
        private System.Windows.Forms.TextBox Txt_Descuento;
        private System.Windows.Forms.TextBox Txt_CodProducto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Label L_Total;
        private System.Windows.Forms.ToolStripMenuItem impuestosYDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Txt_ImpuestosEdit;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Txt_DescuentosEdit;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem historiaDeVentasToolStripMenuItem;
    }
}