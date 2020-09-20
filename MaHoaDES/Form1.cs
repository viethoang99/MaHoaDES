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

        int MaHoaOrGiaMa = 1;//chế độ(=1:mã hoá, =-1:giải mã)
        //RoundKey key;
        F_function des;
        //void MaHoa()
        //{
        //    string cipher = des.MaHoa(txbBanRo.Text, txbKhoa.Text, chose: MaHoaOrGiaMa);
        //    txbKetQua.Text = cipher;
        //}
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string cipher = des.MaHoa(txbBanRo.Text, txbKhoa.Text, 1);
            txbKetQua.Text = cipher;
        }
    }
}
