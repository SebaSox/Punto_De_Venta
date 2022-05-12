
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
            this.Txt_DNI = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Contra = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_NuevoUsuario = new System.Windows.Forms.Button();
            this.B_ModificarUsuario = new System.Windows.Forms.Button();
            this.B_EliminarUsuario = new System.Windows.Forms.Button();
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
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
            // Txt_DNI
            // 
            this.Txt_DNI.Location = new System.Drawing.Point(348, 502);
            this.Txt_DNI.Name = "Txt_DNI";
            this.Txt_DNI.Size = new System.Drawing.Size(100, 22);
            this.Txt_DNI.TabIndex = 2;
            this.Txt_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(496, 502);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(100, 22);
            this.Txt_Telefono.TabIndex = 3;
            this.Txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Contra);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(708, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de acceso:";
            // 
            // Txt_Contra
            // 
            this.Txt_Contra.Location = new System.Drawing.Point(168, 47);
            this.Txt_Contra.Name = "Txt_Contra";
            this.Txt_Contra.Size = new System.Drawing.Size(100, 22);
            this.Txt_Contra.TabIndex = 3;
            this.Txt_Contra.UseSystemPasswordChar = true;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(26, 47);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(100, 22);
            this.Txt_Usuario.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuario ";
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
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono";
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
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(17, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(992, 436);
            this.DataGrid.TabIndex = 13;
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 613);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.B_Cerrar);
            this.Controls.Add(this.B_EliminarUsuario);
            this.Controls.Add(this.B_ModificarUsuario);
            this.Controls.Add(this.B_NuevoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.Txt_DNI);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Nombre);
            this.Name = "FormularioUsuario";
            this.Text = "FormularioUsuario";
            this.Load += new System.EventHandler(this.FormularioUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_DNI;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Contra;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_NuevoUsuario;
        private System.Windows.Forms.Button B_ModificarUsuario;
        private System.Windows.Forms.Button B_EliminarUsuario;
        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}