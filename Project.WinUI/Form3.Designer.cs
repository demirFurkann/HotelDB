namespace Project.WinUI
{
    partial class Form3
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
			this.txtRoomNo = new System.Windows.Forms.TextBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.txtRoomTypeName = new System.Windows.Forms.TextBox();
			this.lstRoom = new System.Windows.Forms.ListBox();
			this.btnYemekEkle = new System.Windows.Forms.Button();
			this.txtYemek = new System.Windows.Forms.TextBox();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.txtGiris = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRoomNo
			// 
			this.txtRoomNo.Location = new System.Drawing.Point(23, 31);
			this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtRoomNo.Name = "txtRoomNo";
			this.txtRoomNo.Size = new System.Drawing.Size(116, 23);
			this.txtRoomNo.TabIndex = 0;
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(23, 144);
			this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(88, 27);
			this.btnEkle.TabIndex = 1;
			this.btnEkle.Text = "ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(23, 74);
			this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(116, 23);
			this.txtUnitPrice.TabIndex = 2;
			// 
			// txtRoomTypeName
			// 
			this.txtRoomTypeName.Location = new System.Drawing.Point(231, 148);
			this.txtRoomTypeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtRoomTypeName.Name = "txtRoomTypeName";
			this.txtRoomTypeName.Size = new System.Drawing.Size(116, 23);
			this.txtRoomTypeName.TabIndex = 3;
			// 
			// lstRoom
			// 
			this.lstRoom.FormattingEnabled = true;
			this.lstRoom.ItemHeight = 15;
			this.lstRoom.Location = new System.Drawing.Point(231, 31);
			this.lstRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.lstRoom.Name = "lstRoom";
			this.lstRoom.Size = new System.Drawing.Size(282, 109);
			this.lstRoom.TabIndex = 5;
			this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
			// 
			// btnYemekEkle
			// 
			this.btnYemekEkle.Location = new System.Drawing.Point(564, 118);
			this.btnYemekEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnYemekEkle.Name = "btnYemekEkle";
			this.btnYemekEkle.Size = new System.Drawing.Size(88, 27);
			this.btnYemekEkle.TabIndex = 6;
			this.btnYemekEkle.Text = "Yemek ekle";
			this.btnYemekEkle.UseVisualStyleBackColor = true;
			this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
			// 
			// txtYemek
			// 
			this.txtYemek.Location = new System.Drawing.Point(551, 42);
			this.txtYemek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtYemek.Name = "txtYemek";
			this.txtYemek.Size = new System.Drawing.Size(116, 23);
			this.txtYemek.TabIndex = 7;
			// 
			// txtFiyat
			// 
			this.txtFiyat.Location = new System.Drawing.Point(551, 73);
			this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(116, 23);
			this.txtFiyat.TabIndex = 8;
			// 
			// txtGiris
			// 
			this.txtGiris.Location = new System.Drawing.Point(12, 249);
			this.txtGiris.Name = "txtGiris";
			this.txtGiris.Size = new System.Drawing.Size(100, 23);
			this.txtGiris.TabIndex = 9;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(11, 278);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(100, 23);
			this.txtSifre.TabIndex = 9;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(12, 318);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 10;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Personel Kayıt";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 353);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtGiris);
			this.Controls.Add(this.txtFiyat);
			this.Controls.Add(this.txtYemek);
			this.Controls.Add(this.btnYemekEkle);
			this.Controls.Add(this.lstRoom);
			this.Controls.Add(this.txtRoomTypeName);
			this.Controls.Add(this.txtUnitPrice);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.txtRoomNo);
			this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtRoomTypeName;
        private System.Windows.Forms.ListBox lstRoom;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.TextBox txtYemek;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.TextBox txtGiris;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Label label1;
	}
}