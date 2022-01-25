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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_video = new FontAwesome.Sharp.IconButton();
            this.btn_imagen = new FontAwesome.Sharp.IconButton();
            this.btn_camara = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_video);
            this.panel1.Controls.Add(this.btn_imagen);
            this.panel1.Controls.Add(this.btn_camara);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 112);
            this.panel1.TabIndex = 3;
            // 
            // btn_video
            // 
            this.btn_video.BackColor = System.Drawing.Color.Transparent;
            this.btn_video.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_video.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btn_video.IconColor = System.Drawing.Color.Black;
            this.btn_video.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_video.Location = new System.Drawing.Point(736, 0);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(268, 112);
            this.btn_video.TabIndex = 3;
            this.btn_video.Text = "Video";
            this.btn_video.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_video.UseVisualStyleBackColor = false;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_imagen
            // 
            this.btn_imagen.BackColor = System.Drawing.Color.Transparent;
            this.btn_imagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_imagen.FlatAppearance.BorderSize = 0;
            this.btn_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btn_imagen.IconColor = System.Drawing.Color.Black;
            this.btn_imagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_imagen.Location = new System.Drawing.Point(468, 0);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(268, 112);
            this.btn_imagen.TabIndex = 2;
            this.btn_imagen.Text = "Imagen";
            this.btn_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imagen.UseVisualStyleBackColor = false;
            this.btn_imagen.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_camara
            // 
            this.btn_camara.BackColor = System.Drawing.Color.Transparent;
            this.btn_camara.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_camara.FlatAppearance.BorderSize = 0;
            this.btn_camara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camara.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camara.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.btn_camara.IconColor = System.Drawing.Color.Black;
            this.btn_camara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_camara.Location = new System.Drawing.Point(200, 0);
            this.btn_camara.Name = "btn_camara";
            this.btn_camara.Size = new System.Drawing.Size(268, 112);
            this.btn_camara.TabIndex = 1;
            this.btn_camara.Text = "Camara";
            this.btn_camara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_camara.UseVisualStyleBackColor = false;
            this.btn_camara.Click += new System.EventHandler(this.btn_camara_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1005, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 112);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 112);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1229, 137);
            this.panel4.TabIndex = 4;
            // 
            // panel_Form
            // 
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form.Location = new System.Drawing.Point(0, 137);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(1229, 596);
            this.panel_Form.TabIndex = 5;
            this.panel_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 733);
            this.Controls.Add(this.panel_Form);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_camara;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_imagen;
        private FontAwesome.Sharp.IconButton btn_video;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_Form;
    }
}