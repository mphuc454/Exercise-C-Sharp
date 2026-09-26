namespace Lab2;

class ChayUngDung
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Students st1 = new Students("SV01", "Hoàng", 15, "Nam");
        Students st2 = new Students("SV02", "Nhân", 15, "Nam");
        Students st3 = new Students("SV03", "Linh", 16, "Nữ");
        Students st4 = new Students("SV04", "Tú", 12, "Nam");
        
        MonHoc monHoc1 = new MonHoc("Lập trình C#", 6.7);
        MonHoc monHoc2 = new MonHoc("Cơ sở dữ liệu", 1.5);
        MonHoc monHoc3 = new MonHoc("Mạng máy tính", 8.0);
        MonHoc monHoc4 = new MonHoc("Công nghệ phần mềm", 5.1);
        MonHoc monHoc5 = new MonHoc("Kiểm thử phần mềm", 7.5);
        MonHoc monHoc6 = new MonHoc("Phân tích thiết kế hệ thống", 3.2);
        
        st1.addMonHoc(monHoc1);
        st1.addMonHoc(monHoc2);
        st1.addMonHoc(monHoc3);
        
        st2.addMonHoc(monHoc5);
        st2.addMonHoc(monHoc6);
        st2.addMonHoc(monHoc1);
        
        st3.addMonHoc(monHoc3);
        st3.addMonHoc(monHoc5);
        st3.addMonHoc(monHoc4);
        
        st4.addMonHoc(monHoc2);
        st4.addMonHoc(monHoc4);
        st4.addMonHoc(monHoc6);
        
        st1.xuatDanhSachMonHoc();
        
    }
}