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
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(52, 40);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNo.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(52, 156);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(52, 77);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Location = new System.Drawing.Point(311, 172);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomTypeName.TabIndex = 3;
            // 
            // lstRoom
            // 
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.Location = new System.Drawing.Point(311, 40);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(242, 95);
            this.lstRoom.TabIndex = 5;
            this.lstRoom.SelectedIndexChanged += new System.EventHandler(this.lstRoom_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}