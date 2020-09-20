using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaDES
{
    class DES_process
    {
        F_function f = new F_function();
        //bảng hoán vị trước khi bắt đầu
        private static readonly int[] initial_perm ={ 58, 50, 42, 34, 26, 18, 10, 2, 60, 52,
                                                    44, 36, 28, 20, 12, 4, 62, 54, 46, 38,
                                                    30, 22, 14, 6, 64, 56, 48, 40, 32, 24,
                                                    16, 8, 57, 49, 41, 33, 25, 17, 9, 1,
                                                    59, 51, 43, 35, 27, 19, 11, 3, 61, 53,
                                                    45, 37, 29, 21, 13, 5, 63, 55, 47, 39,
                                                    31, 23, 15, 7 };
        //bảng hoán vị sau khi kết thúc
        private static readonly int[] final_perm ={ 40, 8, 48, 16, 56, 24, 64, 32, 39, 7,
                                                    47, 15, 55, 23, 63, 31, 38, 6, 46, 14,
                                                    54, 22, 62, 30, 37, 5, 45, 13, 53, 21,
                                                    61, 29, 36, 4, 44, 12, 52, 20, 60, 28,
                                                    35, 3, 43, 11, 51, 19, 59, 27, 34, 2,
                                                    42, 10, 50, 18, 58, 26, 33, 1, 41, 9,
                                                    49, 17, 57, 25 };
        //thực hiện mã hoá
        public string MaHoa(string plaintext, string keyDES, int chose,TextBox tb)//chose=1 mã hoá, chose=-1 giải m
        {
            RoundKey.SinhKhoaCon(keyDES);//chạy hàm tạo khoá con cho các round
            string plainText;
            if (chose == 1)//nếu là mã hoá
            {
                plainText = Method.Chuoi_Nhi(plaintext);//chuyển chuỗi sang nhị phân
                plainText = Method.ChinhDoDai64(plainText);//thêm bit 0 để số bit là bội của 64
            }
            else
            {
                plainText = plaintext;
            }
            tb.Text = "Chuoi ma hoa la: " + plainText + "\r\n\r\n";
            string[] pt = Method.TachChuoi(plainText);//chia thành mảng các chuỗi 64bit để xly

            string SauIP, left, right, F;

            string CipherText = "";

            for (int i = 0; i < pt.Length; i++)//xử lý từng khối 64bit 
            {
                tb.Text = tb.Text + "Xử lý chuỗi thứ " + (i + 1).ToString() + ": " + pt[i] + " \r\n";
                string temp = "";
                SauIP = Method.HoanVi(pt[i], initial_perm);//đưa qua hộp hoán vị đầu vào
                                                            //chia đôi chuỗi
                left = SauIP.Substring(0, 32);
                right = SauIP.Substring(32, 32);

                for (int j = 0; j < 16; j++)//16 round của DES
                {
                    F = f.HamF(right, RoundKey.KhoaPhu[chose == 1 ? j : 15 - j]);//tìm hàm F 
                    left = Method.XOR(left, F);//xor left với F
                                               //hoán vị
                    temp = left;
                    left = right;
                    right = temp;
                    int iTemp = (chose == 1 ? j : 15 - j) + 1;
                    string strTemp = left + right;
                    tb.Text = tb.Text + "Round " + iTemp.ToString() + ": " + "\r\n" +
                        "\tC = " + strTemp + "\r\n" + "\tK = " + RoundKey.KhoaPhu[chose == 1 ? j : 15 - j]
                        + "\r\n";
                }
                string temp1 = "";

                //hoán vị 2 chuỗi
                temp1 += right;
                temp1 += left;

                CipherText += Method.HoanVi(temp1, final_perm);//đưa qua hộp hvi đầu ra
                tb.Text = tb.Text + "Hoán vị: " + CipherText + "\r\n\r\n";
            }
            //CipherText = Method.Binary2String(CipherText);
            if (chose == -1)
            {
                CipherText = Method.CatDuLieu64(CipherText);//loại bỏ các bit đã thêm
                if(CipherText != null)
                {
                    CipherText = Method.Nhi_Chuoi(CipherText);//đưa về kiểu string để hiển thị
                }
                else
                {
                    MessageBox.Show("Không thể giải mã");
                    return null;
                }    
            }
            return CipherText;
        }
    }
}
