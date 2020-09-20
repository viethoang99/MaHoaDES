using System.IO;

namespace MaHoaDES
{
    class RoundKey
    {

        public string KhoaChinh; //khoá chính 64bit
        public static string[] KhoaPhu { get; private set; }//mảng 16 khoá con

        //hoán vị Key
        private static readonly int[] keyp = { 57, 49, 41, 33, 25, 17, 9,
                                             1, 58, 50, 42, 34, 26, 18,
                                             10, 2, 59, 51, 43, 35, 27,
                                             19, 11, 3, 60, 52, 44, 36,
                                             63, 55, 47, 39, 31, 23, 15,
                                             7, 62, 54, 46, 38, 30, 22,
                                             14, 6, 61, 53, 45, 37, 29,
                                             21, 13, 5, 28, 20, 12, 4 };
        //số bit hoán vị theo từng vòng
        private static readonly int[] shift_table = new int[] { 1, 1, 2, 2,
                                                                2, 2, 2, 2,
                                                                1, 2, 2, 2,
                                                                2, 2, 2, 1 };
        //hoán vị lặp lại lần cuối
        private static readonly int[] key_comp = { 14, 17, 11, 24, 1, 5,
                                                     3, 28, 15, 6, 21, 10,
                                                     23, 19, 12, 4, 26, 8,
                                                     16, 7, 27, 20, 13, 2,
                                                     41, 52, 31, 37, 47, 55,
                                                     30, 40, 51, 45, 33, 48,
                                                     44, 49, 39, 56, 34, 53,
                                                     46, 42, 50, 36, 29, 32 };
        //chuyển bản rõ sang nhị phân
        public static string ChuyenASCsangNhiPhan(string BanRo)
        {

            FileStream file = new FileStream("ASCtoNhiPhan", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader doc = new StreamReader(file);

            //đọc từng dòng một
            string Temp = "", NhiPhan = "", ThapPhan = "", Hex = "", ASC = "";

            string[] MangNhiPhan = new string[BanRo.Length];

            Temp = doc.ReadLine();
            int t = 0;

            while (Temp != null)
            {

                NhiPhan = Temp.Substring(0, 8).ToString();
                ThapPhan = Temp.Substring(9, 3).ToString().Trim();
                Hex = Temp.Substring(13, 2).ToString();
                ASC = Temp.Substring(16, 1);

                for (int i = 0; i < BanRo.Length; i++)
                {
                    if (ASC == BanRo[i].ToString())
                    {
                        MangNhiPhan[i] = NhiPhan;
                        t++;
                    }
                }

                if (t == BanRo.Length) break;

                Temp = doc.ReadLine();
            }

            string ChuoiNhiPhan = "";

            for (int i = 0; i < BanRo.Length; i++)
            {
                ChuoiNhiPhan += MangNhiPhan[i];
            }

            doc.Close();
            file.Close();

            return ChuoiNhiPhan;
        }
        //loại bỏ bit kiểm tra chẵn lẻ
        public static string boBitPanity(string K)
        {
            string str = "";

            int stat = 0;

            for (int i = 0; i < 8; i++)
            {
                str += K.Substring(stat, 7);
                stat += 8;
            }

            return str;
        }
        //hoán vị khóa 
        public static string HoanVi(string k, int[] arr)
        {
            string per = "";
            for (int i = 0; i < arr.Length; i++)
            {
                per += k[arr[i] - 1];
            }
            return per;
        }
        public static string DichTrai(string k, int shifts)//phép dịch bit sang trái shifts lần
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
        public static void SinhKhoaCon(string keyASC)
        {
            KhoaPhu = new string[16];// mảng khoá phụ cho 16 round
            //chuyển khóa sang nhị phân
            string KhoaChinh = ChuyenASCsangNhiPhan(keyASC);
            string K = KhoaChinh;
            //loại bỏ bit thừa thành 56bit
            KhoaChinh = boBitPanity(KhoaChinh);
            //hoán vị 
            string KeySauPC1 = HoanVi(K, keyp);// đưa qua hộp hoán vị nén Pbox

            //chia thành 2 nửa trái phải
            string left = KeySauPC1.Substring(0, 28);
            string right = KeySauPC1.Substring(28, 28);

            for (int i = 0; i < 16; i++)
            {
                //dịch trái theo bảng dịch
                left = DichTrai(left, shift_table[i]);
                right = DichTrai(right, shift_table[i]);

                string combine = left + right;//Gộp lại

                KhoaPhu[i] = HoanVi(combine, key_comp);//Đưa qua hộp nén lần 2 rồi lưu vào mảng
            }
        }
    }
}
