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
            this.lstReservasyon = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            this.btnYemek = new System.Windows.Forms.Button();
            this.İsim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(82, 58);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(148, 27);
            this.txtIsim.TabIndex = 0;
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(82, 124);
            this.txtSoyIsim.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(148, 27);
            this.txtSoyIsim.TabIndex = 0;
            // 
            // cmbOda
            // 
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Location = new System.Drawing.Point(82, 219);
            this.cmbOda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(241, 27);
            this.cmbOda.TabIndex = 1;
            this.cmbOda.SelectedIndexChanged += new System.EventHandler(this.cmbOda_SelectedIndexChanged);
            // 
            // lblOda
            // 
            this.lblOda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOda.Location = new System.Drawing.Point(78, 475);
            this.lblOda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(380, 114);
            this.lblOda.TabIndex = 2;
            // 
            // lstReservasyon
            // 
            this.lstReservasyon.FormattingEnabled = true;
            this.lstReservasyon.ItemHeight = 19;
            this.lstReservasyon.Location = new System.Drawing.Point(432, 58);
            this.lstReservasyon.Margin = new System.Windows.Forms.Padding(4);
            this.lstReservasyon.Name = "lstReservasyon";
            this.lstReservasyon.Size = new System.Drawing.Size(562, 213);
            this.lstReservasyon.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(82, 630);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 34);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(884, 282);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(112, 34);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "Çıkış yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Location = new System.Drawing.Point(1013, 55);
            this.cmbYemek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(268, 27);
            this.cmbYemek.TabIndex = 6;
            // 
            // btnYemek
            // 
            this.btnYemek.Location = new System.Drawing.Point(1088, 95);
            this.btnYemek.Margin = new System.Windows.Forms.Padding(4);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(134, 56);
            this.btnYemek.TabIndex = 7;
            this.btnYemek.Text = "Yemek ekle";
            this.btnYemek.UseVisualStyleBackColor = true;
            this.btnYemek.Click += new System.EventHandler(this.btnYemek_Click);
            // 
            // İsim
            // 
            this.İsim.AutoSize = true;
            this.İsim.Location = new System.Drawing.Point(82, 19);
            this.İsim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.İsim.Name = "İsim";
            this.İsim.Size = new System.Drawing.Size(36, 19);
            this.İsim.TabIndex = 8;
            this.İsim.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odalar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.İsim);
            this.Controls.Add(this.btnYemek);
            this.Controls.Add(this.cmbYemek);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstReservasyon);
            this.Controls.Add(this.lblOda);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtIsim);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ListBox lstReservasyon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.ComboBox cmbYemek;
        private System.Windows.Forms.Button btnYemek;
		private System.Windows.Forms.Label İsim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}