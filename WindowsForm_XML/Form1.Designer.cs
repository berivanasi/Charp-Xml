
namespace WindowsFormODEVXML
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
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_Sisim = new System.Windows.Forms.TextBox();
            this.lbl_sisim = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isim.Location = new System.Drawing.Point(29, 67);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(73, 18);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "Öğrenci İsim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(113, 64);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 22);
            this.txt_isim.TabIndex = 1;
            // 
            // txt_Sisim
            // 
            this.txt_Sisim.Location = new System.Drawing.Point(113, 92);
            this.txt_Sisim.Name = "txt_Sisim";
            this.txt_Sisim.Size = new System.Drawing.Size(100, 22);
            this.txt_Sisim.TabIndex = 2;
            // 
            // lbl_sisim
            // 
            this.lbl_sisim.AutoSize = true;
            this.lbl_sisim.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sisim.Location = new System.Drawing.Point(13, 95);
            this.lbl_sisim.Name = "lbl_sisim";
            this.lbl_sisim.Size = new System.Drawing.Size(92, 18);
            this.lbl_sisim.TabIndex = 3;
            this.lbl_sisim.Text = "Öğrenci Soyisim";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(76, 142);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(105, 25);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.lbl_sisim);
            this.groupBox1.Controls.Add(this.txt_Sisim);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Giriş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 306);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_Sisim;
        private System.Windows.Forms.Label lbl_sisim;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

