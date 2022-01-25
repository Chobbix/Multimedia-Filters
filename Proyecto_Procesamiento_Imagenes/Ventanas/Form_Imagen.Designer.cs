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
            this.btn_Filtro1.Location = new System.Drawing.Point(308, 470);
            this.btn_Filtro1.Name = "btn_Filtro1";
            this.btn_Filtro1.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Filtro1.Size = new System.Drawing.Size(149, 35);
            this.btn_Filtro1.TabIndex = 16;
            this.btn_Filtro1.Text = "Grises";
            this.btn_Filtro1.UseVisualStyleBackColor = false;
            this.btn_Filtro1.Click += new System.EventHandler(this.btn_Filtro1_Click);
            // 
            // Form_Imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 593);
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
    }
}