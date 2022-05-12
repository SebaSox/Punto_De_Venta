
namespace punto_de_venta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Entrar = new System.Windows.Forms.Button();
            this.B_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(44, 80);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(308, 22);
            this.Txt_Usuario.TabIndex = 0;
            // 
            // Txt_Contra
            // 
            this.Txt_Contra.Location = new System.Drawing.Point(44, 214);
            this.Txt_Contra.Name = "Txt_Contra";
            this.Txt_Contra.Size = new System.Drawing.Size(308, 22);
            this.Txt_Contra.TabIndex = 1;
            this.Txt_Contra.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // B_Entrar
            // 
            this.B_Entrar.Location = new System.Drawing.Point(44, 299);
            this.B_Entrar.Name = "B_Entrar";
            this.B_Entrar.Size = new System.Drawing.Size(101, 46);
            this.B_Entrar.TabIndex = 4;
            this.B_Entrar.Text = "Entrar";
            this.B_Entrar.UseVisualStyleBackColor = true;
            this.B_Entrar.Click += new System.EventHandler(this.B_Entrar_Click);
            // 
            // B_Salir
            // 
            this.B_Salir.Location = new System.Drawing.Point(251, 299);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(100, 46);
            this.B_Salir.TabIndex = 5;
            this.B_Salir.Text = "Salir";
            this.B_Salir.UseVisualStyleBackColor = true;
            this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_Entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Contra);
            this.Controls.Add(this.Txt_Usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Entrar;
        private System.Windows.Forms.Button B_Salir;
    }
}

