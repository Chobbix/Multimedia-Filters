namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    partial class Form_Camara
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
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.img_Camara = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Camara)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empezar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Empezar.Location = new System.Drawing.Point(156, 49);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Empezar.Size = new System.Drawing.Size(179, 44);
            this.btn_Empezar.TabIndex = 3;
            this.btn_Empezar.Text = "Activar camara";
            this.btn_Empezar.UseVisualStyleBackColor = false;
            this.btn_Empezar.Click += new System.EventHandler(this.btn_Empezar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(355, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(700, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // img_Camara
            // 
            this.img_Camara.Location = new System.Drawing.Point(284, 122);
            this.img_Camara.Name = "img_Camara";
            this.img_Camara.Size = new System.Drawing.Size(657, 414);
            this.img_Camara.TabIndex = 5;
            this.img_Camara.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 593);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1061, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 593);
            this.panel2.TabIndex = 7;
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contador.Location = new System.Drawing.Point(547, 566);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(18, 18);
            this.lbl_Contador.TabIndex = 8;
            this.lbl_Contador.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de personas en camara:";
            // 
            // Form_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Contador);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_Camara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Empezar);
            this.Name = "Form_Camara";
            this.Text = "Form_Camara";
            this.Load += new System.EventHandler(this.Form_Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Empezar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox img_Camara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Label label1;
    }
}