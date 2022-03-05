namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    partial class Form_Imagen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.img_Imagen = new System.Windows.Forms.PictureBox();
            this.btn_Filtro1 = new System.Windows.Forms.Button();
            this.btn_Filtro2 = new System.Windows.Forms.Button();
            this.btn_Filtro3 = new System.Windows.Forms.Button();
            this.btn_Filtro4 = new System.Windows.Forms.Button();
            this.btn_Filtro5 = new System.Windows.Forms.Button();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.btn_Descargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1061, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 593);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 593);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(150, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 70);
            this.panel3.TabIndex = 13;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cargar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cargar.Location = new System.Drawing.Point(515, 76);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Cargar.Size = new System.Drawing.Size(179, 44);
            this.btn_Cargar.TabIndex = 14;
            this.btn_Cargar.Text = "Cargar Imagen";
            this.btn_Cargar.UseVisualStyleBackColor = false;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // img_Imagen
            // 
            this.img_Imagen.Location = new System.Drawing.Point(308, 126);
            this.img_Imagen.Name = "img_Imagen";
            this.img_Imagen.Size = new System.Drawing.Size(597, 338);
            this.img_Imagen.TabIndex = 15;
            this.img_Imagen.TabStop = false;
            // 
            // btn_Filtro1
            // 
            this.btn_Filtro1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Filtro1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtro1.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Filtro1.Location = new System.Drawing.Point(218, 470);
            this.btn_Filtro1.Name = "btn_Filtro1";
            this.btn_Filtro1.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Filtro1.Size = new System.Drawing.Size(149, 35);
            this.btn_Filtro1.TabIndex = 16;
            this.btn_Filtro1.Text = "Grises";
            this.btn_Filtro1.UseVisualStyleBackColor = false;
            this.btn_Filtro1.Click += new System.EventHandler(this.btn_Filtro1_Click);
            // 
            // btn_Filtro2
            // 
            this.btn_Filtro2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Filtro2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtro2.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Filtro2.Location = new System.Drawing.Point(373, 470);
            this.btn_Filtro2.Name = "btn_Filtro2";
            this.btn_Filtro2.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Filtro2.Size = new System.Drawing.Size(149, 35);
            this.btn_Filtro2.TabIndex = 17;
            this.btn_Filtro2.Text = "Invertido";
            this.btn_Filtro2.UseVisualStyleBackColor = false;
            this.btn_Filtro2.Click += new System.EventHandler(this.btn_Filtro2_Click);
            // 
            // btn_Filtro3
            // 
            this.btn_Filtro3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Filtro3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtro3.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Filtro3.Location = new System.Drawing.Point(528, 470);
            this.btn_Filtro3.Name = "btn_Filtro3";
            this.btn_Filtro3.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Filtro3.Size = new System.Drawing.Size(149, 35);
            this.btn_Filtro3.TabIndex = 18;
            this.btn_Filtro3.Text = "Color rojo";
            this.btn_Filtro3.UseVisualStyleBackColor = false;
            this.btn_Filtro3.Click += new System.EventHandler(this.btn_Filtro3_Click);
            // 
            // btn_Filtro4
            // 
            this.btn_Filtro4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Filtro4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtro4.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Filtro4.Location = new System.Drawing.Point(683, 470);
            this.btn_Filtro4.Name = "btn_Filtro4";
            this.btn_Filtro4.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Filtro4.Size = new System.Drawing.Size(149, 35);
            this.btn_Filtro4.TabIndex = 19;
            this.btn_Filtro4.Text = "Brillo";
            this.btn_Filtro4.UseVisualStyleBackColor = false;
            this.btn_Filtro4.Click += new System.EventHandler(this.btn_Filtro4_Click);
            // 
            // btn_Filtro5
            // 
            this.btn_Filtro5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Filtro5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filtro5.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Filtro5.Location = new System.Drawing.Point(838, 470);
            this.btn_Filtro5.Name = "btn_Filtro5";
            this.btn_Filtro5.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Filtro5.Size = new System.Drawing.Size(149, 35);
            this.btn_Filtro5.TabIndex = 20;
            this.btn_Filtro5.Text = "Binario";
            this.btn_Filtro5.UseVisualStyleBackColor = false;
            this.btn_Filtro5.Click += new System.EventHandler(this.btn_Filtro5_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restaurar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Restaurar.Location = new System.Drawing.Point(413, 525);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Restaurar.Size = new System.Drawing.Size(149, 35);
            this.btn_Restaurar.TabIndex = 21;
            this.btn_Restaurar.Text = "Restaurar";
            this.btn_Restaurar.UseVisualStyleBackColor = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Descargar
            // 
            this.btn_Descargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Descargar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Descargar.Location = new System.Drawing.Point(638, 525);
            this.btn_Descargar.Name = "btn_Descargar";
            this.btn_Descargar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Descargar.Size = new System.Drawing.Size(149, 35);
            this.btn_Descargar.TabIndex = 22;
            this.btn_Descargar.Text = "Descargar";
            this.btn_Descargar.UseVisualStyleBackColor = false;
            this.btn_Descargar.Click += new System.EventHandler(this.btn_Descargar_Click);
            // 
            // Form_Imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 593);
            this.Controls.Add(this.btn_Descargar);
            this.Controls.Add(this.btn_Restaurar);
            this.Controls.Add(this.btn_Filtro5);
            this.Controls.Add(this.btn_Filtro4);
            this.Controls.Add(this.btn_Filtro3);
            this.Controls.Add(this.btn_Filtro2);
            this.Controls.Add(this.btn_Filtro1);
            this.Controls.Add(this.img_Imagen);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Imagen";
            this.Text = "Form_Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.img_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.PictureBox img_Imagen;
        private System.Windows.Forms.Button btn_Filtro1;
        private System.Windows.Forms.Button btn_Filtro2;
        private System.Windows.Forms.Button btn_Filtro3;
        private System.Windows.Forms.Button btn_Filtro4;
        private System.Windows.Forms.Button btn_Filtro5;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.Button btn_Descargar;
    }
}