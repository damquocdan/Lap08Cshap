using System.Collections.Generic;
using System.Linq;

namespace Lap08Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>() {
                "To","Ve","hon","nguoi","thi","nguoi","se","tro","thanh","Ke","Thu","cua","ta","chiu","nhuong","nguoi","thi","nguoi","se","la","ban","cua","ta"
            };
            //truy vấn dữ liệu
            var  result1 = from m in data select m;

            // Hiển thị kêts quả

            Console.WriteLine("Hien thi tat ca ket qua");

            foreach(var item in result1)
            {
                Console.WriteLine(item+" ");
            }
            // truy van theo dieu kien lay cac tu la "nguoi"

            IEnumerable<string> results = from m in data where m.Equals("nguoi")
                                          select m;
            // hiển thị kết quả
            Console.WriteLine("\n Truy van theo dieu kien");
            foreach (var item in results)
            {
                Console.WriteLine(item +"");
            }
            // sắp xếp dữ liệu
            IEnumerable<string> results3 = from m in data orderby m select m;
            // Hiển thị kếy quả
            Console.WriteLine("Hien thi tat ca ket qua sap xep");
            foreach (var item in results3)
            {
                Console.WriteLine(item +"");
            }
            // lấy tập dữ liệu mới
            var result4 = from m in data
                          select new
                          {
                              Thuong = m.ToLower(),
                              Hoa = m.ToUpper()
                          };
            // hiển thị kêt quả
            Console.WriteLine("Chu thuong va hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.Thuong+" "+item.Hoa);
            }
        }
    }
}