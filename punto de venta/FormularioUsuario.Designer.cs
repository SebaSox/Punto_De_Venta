
namespace punto_de_venta
{
    partial class FormularioUsuario
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
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_CodCliente = new System.Windows.Forms.TextBox();
            this.Txt_DescCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_NuevoUsuario = new System.Windows.Forms.Button();
            this.B_ModificarUsuario = new System.Windows.Forms.Button();
            this.B_EliminarUsuario = new System.Windows.Forms.Button();
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(15, 502);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.Txt_Nombre.TabIndex = 0;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetas);
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(176, 502);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(100, 22);
            this.Txt_Apellido.TabIndex = 1;
            this.Txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetas);
            // 
            // Txt_CodCliente
            // 
            this.Txt_CodCliente.Location = new System.Drawing.Point(348, 502);
            this.Txt_CodCliente.Name = "Txt_CodCliente";
            this.Txt_CodCliente.Size = new System.Drawing.Size(100, 22);
            this.Txt_CodCliente.TabIndex = 2;
            this.Txt_CodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // Txt_DescCliente
            // 
            this.Txt_DescCliente.Location = new System.Drawing.Point(496, 502);
            this.Txt_DescCliente.Name = "Txt_DescCliente";
            this.Txt_DescCliente.Size = new System.Drawing.Size(100, 22);
            this.Txt_DescCliente.TabIndex = 3;
            this.Txt_DescCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descuento Cliente";
            // 
            // B_NuevoUsuario
            // 
            this.B_NuevoUsuario.Location = new System.Drawing.Point(15, 552);
            this.B_NuevoUsuario.Name = "B_NuevoUsuario";
            this.B_NuevoUsuario.Size = new System.Drawing.Size(133, 48);
            this.B_NuevoUsuario.TabIndex = 9;
            this.B_NuevoUsuario.Text = "Nuevo Usuario";
            this.B_NuevoUsuario.UseVisualStyleBackColor = true;
            this.B_NuevoUsuario.Click += new System.EventHandler(this.B_NuevoUsuario_Click);
            // 
            // B_ModificarUsuario
            // 
            this.B_ModificarUsuario.Location = new System.Drawing.Point(176, 553);
            this.B_ModificarUsuario.Name = "B_ModificarUsuario";
            this.B_ModificarUsuario.Size = new System.Drawing.Size(133, 48);
            this.B_ModificarUsuario.TabIndex = 10;
            this.B_ModificarUsuario.Text = "Modificar Usuario";
            this.B_ModificarUsuario.UseVisualStyleBackColor = true;
            this.B_ModificarUsuario.Click += new System.EventHandler(this.B_ModificarUsuario_Click);
            // 
            // B_EliminarUsuario
            // 
            this.B_EliminarUsuario.Location = new System.Drawing.Point(348, 553);
            this.B_EliminarUsuario.Name = "B_EliminarUsuario";
            this.B_EliminarUsuario.Size = new System.Drawing.Size(133, 48);
            this.B_EliminarUsuario.TabIndex = 11;
            this.B_EliminarUsuario.Text = "Eliminar Usuario";
            this.B_EliminarUsuario.UseVisualStyleBackColor = true;
            this.B_EliminarUsuario.Click += new System.EventHandler(this.B_EliminarUsuario_Click);
            // 
            // B_Cerrar
            // 
            this.B_Cerrar.Location = new System.Drawing.Point(876, 552);
            this.B_Cerrar.Name = "B_Cerrar";
            this.B_Cerrar.Size = new System.Drawing.Size(133, 48);
            this.B_Cerrar.TabIndex = 12;
            this.B_Cerrar.Text = "Cerrar";
            this.B_Cerrar.UseVisualStyleBackColor = true;
            this.B_Cerrar.Click += new System.EventHandler(this.B_Cerrar_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(17, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(992, 436);
            this.DataGrid.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Correo";
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Location = new System.Drawing.Point(649, 502);
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Correo.TabIndex = 4;
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 613);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Txt_Correo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B_Cerrar);
            this.Controls.Add(this.B_EliminarUsuario);
            this.Controls.Add(this.B_ModificarUsuario);
            this.Controls.Add(this.B_NuevoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_DescCliente);
            this.Controls.Add(this.Txt_CodCliente);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Nombre);
            this.Name = "FormularioUsuario";
            this.Text = "FormularioUsuario";
            this.Load += new System.EventHandler(this.FormularioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_CodCliente;
        private System.Windows.Forms.TextBox Txt_DescCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_NuevoUsuario;
        private System.Windows.Forms.Button B_ModificarUsuario;
        private System.Windows.Forms.Button B_EliminarUsuario;
        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Correo;
    }
}