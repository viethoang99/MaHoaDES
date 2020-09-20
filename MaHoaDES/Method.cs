using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaDES
{
    class Method
    {
        public static string ChinhDoDai64(string s)//thêm bit 0 để độ dài chuỗi plaintext === 64
        {
            if (s.Length % 8 != 0)
            {
                while (s.Length % 8 != 0)
                {
                    s += "0";
                }
            }
            return s;
        }
        public static string XOR(string a, string b)//xor 2 chuỗi bit
        {
            if (a.Length != b.Length)
                return null;
            string ans = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    ans += "0";
                }
                else
                {
                    ans += "1";
                }
            }
            return ans;
        }
        public static string shift_left(string k, int shifts)//phép dịch bit sang trái shifts lần
        {
            string s = "";
            for (int i = 0; i < shifts; i++)
            {
                for (int j = 1; j < k.Length; j++)
                {
                    s += k[j];
                }
                s += k[0];
                k = s;
                s = "";
            }
            return k;
        }
        public static string String2Binary(string data)// string sang kiểu nhị phân
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public static string Binary2String(string data)// từ nhị phân sang string
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static int Binary2Dec(string data)//chuyển hệ nhị phân sang hệ 10
        {
            int KQ = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                KQ += int.Parse(data[i].ToString()) * (int)Math.Pow(2, data.Length - i - 1);
            }
            return KQ;
        }
        public static string Dec2Binary(int SoInput, int dodai)//chuyển hệ 10 sang hệ nhị phân
        {
            string ChuoiKQ = "";
            int i = dodai - 1;
            int[] temp = new int[dodai];
            while (SoInput > 0)
            {
                temp[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            for (int j = 0; j < dodai; j++)
            {
                ChuoiKQ += temp[j].ToString();
            }
            return ChuoiKQ;
        }

        public static string Hex2Binary(string hexvalue)//từ kiểu hex sang nhị phân
        {
            return String.Join(String.Empty, hexvalue.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }

        public static string Permute(string k, int[] arr)//hoán vị
        {
            string per = "";
            for (int i = 0; i < arr.Length; i++)
            {
                per += k[arr[i] - 1];
            }
            return per;
        }
        public static string[] SplitString(string s)// tách thành các chuỗi con 64bit
        {
            int SoLuong = s.Length / 64;
            string[] KQ = new string[SoLuong];
            for (int i = 0; i < SoLuong; i++)
            {
                KQ[i] = s.Substring(i * 64, 64);
            }
            return (KQ);
        }
        public static string Thap_Nhi(int n)
        {
            string strNhiPhan = "";

            Stack<int> np = new Stack<int>();

            while (n != 0)
            {
                np.Push(n % 2);
                n /= 2;
            }

            while (np.Count > 0)
            {
                strNhiPhan += np.Pop().ToString();
            }


            while (strNhiPhan.Length < 8)
                strNhiPhan = "0" + strNhiPhan;

            return strNhiPhan;
        }
        public static string CatDuLieu64(string data)
        {
            try
            {
                string ChuoiChieuDai = data.Substring(data.Length - 64, 64);// lấy 64 bit cuối
                int d = Method.Binary2Dec(ChuoiChieuDai); // chuyển sang số
                string KQ = data.Substring(0, data.Length - 64); // chỉ lấy số bit tương ứng vs chiefu dài
                if (d < 0 || d > KQ.Length)
                    return null;
                KQ = KQ.Substring(0, d);
                return KQ;
            }
            catch (Exception e)
            {
                MessageBox.Show("Đoạn mã không hợp lệ");
                return "";
            }

        }
    }
}
