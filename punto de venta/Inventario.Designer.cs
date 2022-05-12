
namespace punto_de_venta
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.Txt_CodigoProd = new System.Windows.Forms.TextBox();
            this.Txt_producto = new System.Windows.Forms.TextBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.GridViewInventario = new System.Windows.Forms.DataGridView();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Modificar = new System.Windows.Forms.Button();
            this.B_Anadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // B_Cerrar
            // 
            this.B_Cerrar.Location = new System.Drawing.Point(13, 436);
            this.B_Cerrar.Name = "B_Cerrar";
            this.B_Cerrar.Size = new System.Drawing.Size(161, 65);
            this.B_Cerrar.TabIndex = 8;
            this.B_Cerrar.Text = "Cerrar";
            this.B_Cerrar.UseVisualStyleBackColor = true;
            this.B_Cerrar.Click += new System.EventHandler(this.B_Cerrar_Click);
            // 
            // Txt_CodigoProd
            // 
            this.Txt_CodigoProd.Location = new System.Drawing.Point(289, 530);
            this.Txt_CodigoProd.Name = "Txt_CodigoProd";
            this.Txt_CodigoProd.Size = new System.Drawing.Size(127, 22);
            this.Txt_CodigoProd.TabIndex = 1;
            this.Txt_CodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // Txt_producto
            // 
            this.Txt_producto.Location = new System.Drawing.Point(453, 530);
            this.Txt_producto.Name = "Txt_producto";
            this.Txt_producto.Size = new System.Drawing.Size(127, 22);
            this.Txt_producto.TabIndex = 2;
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(750, 530);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(127, 22);
            this.Txt_Precio.TabIndex = 4;
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // GridViewInventario
            // 
            this.GridViewInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewInventario.Location = new System.Drawing.Point(190, 13);
            this.GridViewInventario.Name = "GridViewInventario";
            this.GridViewInventario.RowHeadersWidth = 51;
            this.GridViewInventario.RowTemplate.Height = 24;
            this.GridViewInventario.Size = new System.Drawing.Size(788, 488);
            this.GridViewInventario.TabIndex = 10;
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Location = new System.Drawing.Point(13, 365);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(161, 65);
            this.B_Eliminar.TabIndex = 7;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Modificar
            // 
            this.B_Modificar.Location = new System.Drawing.Point(13, 294);
            this.B_Modificar.Name = "B_Modificar";
            this.B_Modificar.Size = new System.Drawing.Size(161, 65);
            this.B_Modificar.TabIndex = 6;
            this.B_Modificar.Text = "Modificar";
            this.B_Modificar.UseVisualStyleBackColor = true;
            this.B_Modificar.Click += new System.EventHandler(this.B_Modificar_Click);
            // 
            // B_Anadir
            // 
            this.B_Anadir.Location = new System.Drawing.Point(13, 223);
            this.B_Anadir.Name = "B_Anadir";
            this.B_Anadir.Size = new System.Drawing.Size(161, 65);
            this.B_Anadir.TabIndex = 5;
            this.B_Anadir.Text = "Añadir";
            this.B_Anadir.UseVisualStyleBackColor = true;
            this.B_Anadir.Click += new System.EventHandler(this.B_Anadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Categoria";
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.Location = new System.Drawing.Point(599, 530);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(127, 22);
            this.Txt_Categoria.TabIndex = 3;
            this.Txt_Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetas);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Anadir);
            this.Controls.Add(this.B_Modificar);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.GridViewInventario);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.Txt_producto);
            this.Controls.Add(this.Txt_CodigoProd);
            this.Controls.Add(this.B_Cerrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.TextBox Txt_CodigoProd;
        private System.Windows.Forms.TextBox Txt_producto;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.DataGridView GridViewInventario;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.Button B_Anadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Categoria;
    }
}