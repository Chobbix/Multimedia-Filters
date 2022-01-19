namespace Proyecto_Procesamiento_Imagenes
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.img_Camara = new System.Windows.Forms.PictureBox();
            this.btn_Empezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Camara)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // img_Camara
            // 
            this.img_Camara.Location = new System.Drawing.Point(12, 59);
            this.img_Camara.Name = "img_Camara";
            this.img_Camara.Size = new System.Drawing.Size(675, 441);
            this.img_Camara.TabIndex = 1;
            this.img_Camara.TabStop = false;
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.Location = new System.Drawing.Point(345, 12);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Size = new System.Drawing.Size(134, 24);
            this.btn_Empezar.TabIndex = 2;
            this.btn_Empezar.Text = "Empezar";
            this.btn_Empezar.UseVisualStyleBackColor = true;
            this.btn_Empezar.Click += new System.EventHandler(this.btn_Empezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 527);
            this.Controls.Add(this.btn_Empezar);
            this.Controls.Add(this.img_Camara);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Camara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox img_Camara;
        private System.Windows.Forms.Button btn_Empezar;
    }
}