using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTrungNguyen_BTVN_Tuan1_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = nhap("Nhap m"),
                n = nhap("Nhap n");
            if (n < m)
            {
                int c = n;
                n = m;
                m = c;
            }
            Console.Write("Danh sach cac so chan trong [{0}, {1}] la: ", m, n);
            foreach (int i in lstSoChan(m, n))
                Console.Write("{0}  ", i);
            Console.WriteLine();
            Console.ReadKey();
        }
        static List<int> lstSoChan(int m, int n)
        {
            List<int> lst = new List<int>();
            for (int i = m; i <= n; i++)
                if (i % 2 == 0) lst.Add(i);
            return lst;
        }
        static int nhap(string str)
        {
            try
            {
                Console.Write(str + ": ");
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("So vua nhap khong hop le! Nhan phim bat ki de nhap lai!");
                Console.ReadKey();
                Console.Clear();
                return nhap(str);
            }
        }
    }
}
