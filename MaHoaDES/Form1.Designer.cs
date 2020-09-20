namespace MaHoaDES
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
            this.txbBanRo = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.TxbMaHoa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbQuaTrinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbBanRo
            // 
            this.txbBanRo.Location = new System.Drawing.Point(92, 23);
            this.txbBanRo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBanRo.Multiline = true;
            this.txbBanRo.Name = "txbBanRo";
            this.txbBanRo.Size = new System.Drawing.Size(239, 66);
            this.txbBanRo.TabIndex = 0;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(92, 110);
            this.txbKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbKhoa.MaxLength = 8;
            this.txbKhoa.Multiline = true;
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(239, 28);
            this.txbKhoa.TabIndex = 1;
            // 
            // TxbMaHoa
            // 
            this.TxbMaHoa.Location = new System.Drawing.Point(92, 173);
            this.TxbMaHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxbMaHoa.Multiline = true;
            this.TxbMaHoa.Name = "TxbMaHoa";
            this.TxbMaHoa.Size = new System.Drawing.Size(239, 77);
            this.TxbMaHoa.TabIndex = 2;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(359, 42);
            this.btnMaHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(116, 47);
            this.btnMaHoa.TabIndex = 3;
            this.btnMaHoa.Text = "Mã hóa DES";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(550, 22);
            this.txbKetQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbKetQua.Multiline = true;
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(259, 228);
            this.txbKetQua.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bản rõ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khóa K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bản mã hóa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Giải mã DES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả:";
            // 
            // txbQuaTrinh
            // 
            this.txbQuaTrinh.Location = new System.Drawing.Point(54, 291);
            this.txbQuaTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.txbQuaTrinh.Multiline = true;
            this.txbQuaTrinh.Name = "txbQuaTrinh";
            this.txbQuaTrinh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbQuaTrinh.Size = new System.Drawing.Size(737, 192);
            this.txbQuaTrinh.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 505);
            this.Controls.Add(this.txbQuaTrinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.TxbMaHoa);
            this.Controls.Add(this.txbKhoa);
            this.Controls.Add(this.txbBanRo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBanRo;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.TextBox TxbMaHoa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txbKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbQuaTrinh;
    }
}

