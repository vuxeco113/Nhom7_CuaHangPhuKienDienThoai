namespace frmMain
{
    partial class frmDoiMatKhau
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
            this.txtPassWordCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWordMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassWordXacNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassWordCu
            // 
            this.txtPassWordCu.Location = new System.Drawing.Point(133, 23);
            this.txtPassWordCu.Name = "txtPassWordCu";
            this.txtPassWordCu.Size = new System.Drawing.Size(220, 22);
            this.txtPassWordCu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // txtPassWordMoi
            // 
            this.txtPassWordMoi.Location = new System.Drawing.Point(133, 51);
            this.txtPassWordMoi.Name = "txtPassWordMoi";
            this.txtPassWordMoi.Size = new System.Drawing.Size(220, 22);
            this.txtPassWordMoi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật Khẩu Mới";
            // 
            // txtPassWordXacNhan
            // 
            this.txtPassWordXacNhan.Location = new System.Drawing.Point(133, 79);
            this.txtPassWordXacNhan.Name = "txtPassWordXacNhan";
            this.txtPassWordXacNhan.Size = new System.Drawing.Size(220, 22);
            this.txtPassWordXacNhan.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xác Nhận";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(20, 123);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(110, 32);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(243, 123);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 187);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtPassWordXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassWordMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWordCu);
            this.Controls.Add(this.label2);
            this.Name = "frmDoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassWordCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassWordMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassWordXacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}