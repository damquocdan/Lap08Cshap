namespace _8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo chugn
            int[] Numbers = { 7, 9, 3, 4, 5, 6, 2, 3, 4, 1, 5, 2, 3, 4, };
            string[] Words = {
                "Chỉ","Chích","Phê","Phán","người","khác"
                ,"giống","như","con","chim","bồ","câu",
                "đưa","thư","bao","giờ","cũng","quay","về","nơi","xuất","phát"
            };
            List<Film> listFilm = new List<Film>() {
                new Film
                {
                    FilmId="f1",
                    FilmName="Diepvien007",
                    Price=120000
                },
                new Film
                {
                    FilmId="f2",
                    FilmName="Tam quốc diễn nghĩa",
                    Price=120000
                },
                new Film
                {
                    FilmId="f3",
                    FilmName="Thiếu lâm truyền kỳ",
                    Price=130000
                },
                new Film
                {
                    FilmId="f4",
                    FilmName="Người nhện 2",
                    Price=16000

                },
                new Film
                {
                    FilmId="f5",
                    FilmName="Ngân hàng tình yêu",
                    Price=100000
                },
                new Film
                {
                    FilmId="f6",
                    FilmName="Người đẹp và quái thú",
                    Price=340000
                },
                new Film
                {
                    FilmId="f7",
                    FilmName="Biệt động Sài Gòn",
                    Price=230000
                },
            };
            // Lọc các số chẵn
            IEnumerable<int> querynumber = Numbers.Where(n => n%2 ==0 );
            Show<int>(querynumber, "Loc cac so chan:");
            // lọc các từ có độ dài lớn hơn 4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "loc cac tu co do dai >4");
            // Lọc các từ có tên bắt đầu bằng chữ t
            IEnumerable<string>queryT=Words.Where(w => w.StartsWith("t"));
            Show<string>(queryT, "Loc cac tu co ten bat dau bang chu t:");
            // loc cac so duy nhat trong ca tap so
            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "loc cac so duy nhat trong cac tap so:");
            // đếm xem có bao nhiêu từ không trùng nhau
            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("Dem xem co bao nhieu tu trung nhau:"+countDistinct);
            // lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(3);
            Show<int>(fourNumber, "Lay 4 so dau tien trong day");
            // lấy 2 từ đầu tiên trong câu
            var twoword = Words.Take(2);
            Show<string>(twoword, "Lay 2 tu dau tien trong cau");
            // lấy những từ đầu tiên có chứa chữ t
            var searchword = Words.TakeWhile(w=>w.Contains("t"));
            Show<string>(searchword, "lay nhung tu dau tien co chua chu t:");
            //sắp xếp theo đơngias, lấy những phim đầu tiên có đơn giá <200000   
            var queryfilm = listFilm.OrderBy(f=>f.Price)
                .Select(x=> new {x.FilmId,x.FilmName,x.Price})
                .ToList().TakeWhile(t=>t.Price<200000);
            // Bỏ qua  3 phần tửu đầu tiên, lấy tất cả  các phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "Bo qua 3 phan tu dau tiên lây cac phân tử còn lại");
            // Bỏ qua 4 phần tử đầu tiên lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "Bo qua 4 phan tu dau tien, lay 3 phan tu ke tiếp");

            // Bỏ qua 3 phim đầu tiên lấy 3 phim kế tiếo ( có thể áp dụng phân trnag)
            var  SkipTakeFilm = listFilm.Skip(3).Take(3);
            Show<Film>(SkipTakeFilm, "Bo qua 3 phim dau tien lay 3 phim ke tiep:");

            // sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "Săp xep giam dan , sau do lay cac phan tu <5");
            
        }
        static void Show<T>(IEnumerable<T> data,string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}