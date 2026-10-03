namespace Lab2;

public class ThaoTacDuLieu
{
    private List<Students> sinhVien = new List<Students>();

    public bool kiemTraMaSV(string masv)
    {
        foreach (var sv in sinhVien)
        {
            if (sv.MaSv == masv)
            {
                return true;
            }
        }
        return false;
    }
    public void themSV(string maSv, string hoTen, int tuoi, bool gioiTinh, List<double> diem)
    {
        if (kiemTraMaSV(maSv))
        {
            Console.WriteLine("Mã sv đã tồn tại");
        }
        Students newST = new Students();
        newST.MaSv = maSv;  
        newST.HoTen = hoTen;
        newST.Tuoi = tuoi;
        newST.GioiTinh = gioiTinh;
        foreach (var d in diem)
        {
            newST.themDiem(d);

        }
        sinhVien.Add(newST);
    }

    public void xemDSSinhVien()
    {
        Console.WriteLine("XEM DANH SÁCH SINH VIÊN: ");
        foreach (var sv in sinhVien)
        {
            Console.WriteLine(sv);
        }
    }
}