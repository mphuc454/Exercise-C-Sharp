namespace Lab2;

class ChayUngDung
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        ThaoTacDuLieu dl = new ThaoTacDuLieu();
        dl.themSV("SV01", "Hoàng", 15, false, new List<double>{5.6, 1.1, 4.7 });
        dl.themSV("SV02", "Nhân", 15, false, new List<double>{5.6, 8.7, 6.9, 9.3 });   
        dl.themSV("SV03", "Linh", 16, true, new List<double>{3.6, 5.1, 6.2, 5.4 });
        dl.themSV("SV04", "Tú", 12, true, new List<double>{7.7, 8.7, 9.9 });
        dl.xemDSSinhVien();
    }
}