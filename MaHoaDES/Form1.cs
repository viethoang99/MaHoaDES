using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int MaHoaOrGiaMa = 1;//chế độ(=1:mã hoá, =-1:giải mã)
        //RoundKey key;
        DES_process des;
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            des = new DES_process();
            if (txbKhoa.Text.Length == 8)
            {
                string cipher = des.MaHoa(txbBanRo.Text, txbKhoa.Text, 1);
                txbKetQua.Text = cipher;
            }
            else
                MessageBox.Show("Khoá không hợp lệ");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            des = new DES_process();
            string plain = des.MaHoa(TxbMaHoa.Text, txbKhoa.Text, -1);
            txbKetQua.Text = plain;
        }
    }
}
