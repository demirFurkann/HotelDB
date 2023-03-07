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
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(20, 27);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNo.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 143);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(20, 64);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Location = new System.Drawing.Point(198, 128);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomTypeName.TabIndex = 3;
            // 
            // lstRoom
            // 
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.Location = new System.Drawing.Point(198, 27);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(242, 95);
            this.lstRoom.TabIndex = 5;
            this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.Location = new System.Drawing.Point(789, 90);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYemekEkle.TabIndex = 6;
            this.btnYemekEkle.Text = "Yemek ekle";
            this.btnYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(789, 42);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(100, 20);
            this.txtYemek.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 499);
            this.Controls.Add(this.txtYemek);
            this.Controls.Add(this.btnYemekEkle);
            this.Controls.Add(this.lstRoom);
            this.Controls.Add(this.txtRoomTypeName);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtRoomNo);
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
    }
}