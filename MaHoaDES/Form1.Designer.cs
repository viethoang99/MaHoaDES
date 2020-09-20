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
            this.SuspendLayout();
            // 
            // txbBanRo
            // 
            this.txbBanRo.Location = new System.Drawing.Point(123, 28);
            this.txbBanRo.Multiline = true;
            this.txbBanRo.Name = "txbBanRo";
            this.txbBanRo.Size = new System.Drawing.Size(317, 80);
            this.txbBanRo.TabIndex = 0;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(123, 136);
            this.txbKhoa.MaxLength = 8;
            this.txbKhoa.Multiline = true;
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(317, 34);
            this.txbKhoa.TabIndex = 1;
            // 
            // TxbMaHoa
            // 
            this.TxbMaHoa.Location = new System.Drawing.Point(123, 213);
            this.TxbMaHoa.Multiline = true;
            this.TxbMaHoa.Name = "TxbMaHoa";
            this.TxbMaHoa.Size = new System.Drawing.Size(317, 94);
            this.TxbMaHoa.TabIndex = 2;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(49, 380);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(154, 58);
            this.btnMaHoa.TabIndex = 3;
            this.btnMaHoa.Text = "Mã hóa DES";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(492, 12);
            this.txbKetQua.Multiline = true;
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(298, 428);
            this.txbKetQua.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bản rõ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khóa K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bản mã hóa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Giải mã DES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.TxbMaHoa);
            this.Controls.Add(this.txbKhoa);
            this.Controls.Add(this.txbBanRo);
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
    }
}

