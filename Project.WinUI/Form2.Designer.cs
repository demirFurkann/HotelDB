namespace Project.WinUI
{
    partial class Form2
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.lblOda = new System.Windows.Forms.Label();
            this.lstDoluOda = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            this.btnYemek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(55, 40);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(55, 85);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyIsim.TabIndex = 0;
            // 
            // cmbOda
            // 
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Location = new System.Drawing.Point(55, 220);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(273, 21);
            this.cmbOda.TabIndex = 1;
            // 
            // lblOda
            // 
            this.lblOda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOda.Location = new System.Drawing.Point(52, 325);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(253, 78);
            this.lblOda.TabIndex = 2;
            // 
            // lstDoluOda
            // 
            this.lstDoluOda.FormattingEnabled = true;
            this.lstDoluOda.Location = new System.Drawing.Point(288, 40);
            this.lstDoluOda.Name = "lstDoluOda";
            this.lstDoluOda.Size = new System.Drawing.Size(376, 147);
            this.lstDoluOda.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(55, 431);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(589, 193);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(75, 23);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "Çıkış yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Location = new System.Drawing.Point(772, 40);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(121, 21);
            this.cmbYemek.TabIndex = 6;
            // 
            // btnYemek
            // 
            this.btnYemek.Location = new System.Drawing.Point(812, 81);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(75, 23);
            this.btnYemek.TabIndex = 7;
            this.btnYemek.Text = "Yemek ekle";
            this.btnYemek.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 527);
            this.Controls.Add(this.btnYemek);
            this.Controls.Add(this.cmbYemek);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstDoluOda);
            this.Controls.Add(this.lblOda);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.Label lblOda;
        private System.Windows.Forms.ListBox lstDoluOda;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.ComboBox cmbYemek;
        private System.Windows.Forms.Button btnYemek;
    }
}