namespace BTLap8._1Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> listBook = new List<Book>() {
                new Book(){id=10,name="damquocdan",author="damquocdan",price=1000,publisher="nha xuat ban Giao Duc", year=2015 },
                new Book(){id=11,name="damquocdan",author="damquocdan",price=2000,publisher="Nhi Dong", year=2016 },
                new Book(){id=12,name="damquocdan",author="damquocdan",price=4000,publisher="nha xuat ban Giao Duc", year=2017 },
                new Book(){id=13,name="lap trinh",author="damquocdan",price=5400,publisher="nha xuat ban Giao Duc", year=2015 },
                new Book(){id=14,name="damquocdan",author="damquocdan",price=2000,publisher="nha xuat ban Giao Duc", year=2013 },
                new Book(){id=15,name="damquocdan",author="damquocdan",price=4000,publisher="hihi", year=2016 },
                new Book(){id=16,name="damquocdan",author="damquocdan",price=3300,publisher="nha xuat ban Giao Duc", year=2018 },
                new Book(){id=17,name="lap trinh",author="damquocdan",price=6000,publisher="nha xuat ban Giao Duc", year=2013 },
                new Book(){id=18,name="damquocdan",author="damquocdan",price=8000,publisher="nha xuat ban Giao Duc", year=2012 },
                new Book(){id=19,name="damquocdan",author="damquocdan",price=7000,publisher="nha xuat ban Giao Duc", year=2011 },
            };
            foreach (var item in listBook)
            {
                Console.WriteLine(item.id+" "+item.name+" "+item.author+""+item.price+""+item.publisher+" "+item.year);
            }
            Console.WriteLine("Hien thị nhữung quyển sáchc có giá từ 1000-5000");
            var priceBook = from c in listBook where c.price > 999 && c.price < 5001 select c;
            foreach (var item in priceBook)
            {
                Console.WriteLine(item.id + " " + item.name + " " + item.author + "" + item.price + "" + item.publisher + " " + item.year);

            }
            Console.WriteLine("Hien thi nhung quyen sach xuat ban nam 2015");
            var yearBook = from y in listBook where y.year.Equals(2015) select y;
            foreach (var item in yearBook)
            {
                Console.WriteLine(item.id + " " + item.name + " " + item.author + "" + item.price + "" + item.publisher + " " + item.year);

            }
            Console.WriteLine("Hien thi nhung sách có tên lập trình");
            var nameBook = from n in listBook where n.name.Equals("lap trinh") select n;
            foreach (var item in nameBook)
            {
                Console.WriteLine(item.id + " " + item.name + " " + item.author + "" + item.price + "" + item.publisher + " " + item.year);
            }

            var countBook = from c in listBook where c.publisher.Equals("nha xuat ban Giao Duc") select c;
            var cBook = countBook.Count();
            Console.WriteLine("Đếm các quyển sách của nhà xuất bản giáo dục:{0}",cBook);
        }
    }
}