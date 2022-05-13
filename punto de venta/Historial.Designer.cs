
namespace punto_de_venta
{
    partial class Historial
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
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.B_BuscarHistorial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Imprimir = new System.Windows.Forms.Button();
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.L_Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Location = new System.Drawing.Point(196, 12);
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.RowHeadersWidth = 51;
            this.dataGridHistorial.RowTemplate.Height = 24;
            this.dataGridHistorial.Size = new System.Drawing.Size(893, 517);
            this.dataGridHistorial.TabIndex = 0;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(13, 148);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(159, 22);
            this.Txt_Buscar.TabIndex = 1;
            // 
            // B_BuscarHistorial
            // 
            this.B_BuscarHistorial.Location = new System.Drawing.Point(13, 186);
            this.B_BuscarHistorial.Name = "B_BuscarHistorial";
            this.B_BuscarHistorial.Size = new System.Drawing.Size(159, 62);
            this.B_BuscarHistorial.TabIndex = 2;
            this.B_BuscarHistorial.Text = "Buscar";
            this.B_BuscarHistorial.UseVisualStyleBackColor = true;
            this.B_BuscarHistorial.Click += new System.EventHandler(this.B_BuscarHistorial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::punto_de_venta.Properties.Resources.GENERICA;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // B_Imprimir
            // 
            this.B_Imprimir.Location = new System.Drawing.Point(13, 276);
            this.B_Imprimir.Name = "B_Imprimir";
            this.B_Imprimir.Size = new System.Drawing.Size(159, 62);
            this.B_Imprimir.TabIndex = 4;
            this.B_Imprimir.Text = "Imprimir";
            this.B_Imprimir.UseVisualStyleBackColor = true;
            // 
            // B_Cerrar
            // 
            this.B_Cerrar.Location = new System.Drawing.Point(12, 362);
            this.B_Cerrar.Name = "B_Cerrar";
            this.B_Cerrar.Size = new System.Drawing.Size(159, 62);
            this.B_Cerrar.TabIndex = 5;
            this.B_Cerrar.Text = "Cerrar";
            this.B_Cerrar.UseVisualStyleBackColor = true;
            this.B_Cerrar.Click += new System.EventHandler(this.B_Cerrar_Click);
            // 
            // L_Total
            // 
            this.L_Total.AutoSize = true;
            this.L_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.L_Total.Location = new System.Drawing.Point(870, 556);
            this.L_Total.Name = "L_Total";
            this.L_Total.Size = new System.Drawing.Size(0, 39);
            this.L_Total.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(760, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOTAL:";
            // 
            // L_Cliente
            // 
            this.L_Cliente.AutoSize = true;
            this.L_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.L_Cliente.Location = new System.Drawing.Point(382, 556);
            this.L_Cliente.Name = "L_Cliente";
            this.L_Cliente.Size = new System.Drawing.Size(0, 39);
            this.L_Cliente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(273, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 629);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Total);
            this.Controls.Add(this.B_Cerrar);
            this.Controls.Add(this.B_Imprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_BuscarHistorial);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.dataGridHistorial);
            this.Name = "Historial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Button B_BuscarHistorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_Imprimir;
        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.Label L_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Cliente;
        private System.Windows.Forms.Label label3;
    }
}