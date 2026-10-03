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

    public void timKiemMaSV(string masv)
    {
        foreach (Students st in sinhVien )
        {
            if (st.MaSv.Equals(masv))
            {
                Console.Write($"Tìm thấy SV {st.MaSv} - {st.HoTen}");
                Console.WriteLine();
                return;
            }
            
        }
        Console.WriteLine("Không tìm thấy");
    }

    public void capNhatSV(string maSv, string hoTen, int tuoi, bool gioiTinh, List<double> diem)
    {
        foreach (var updateST in sinhVien)
        {
            if (updateST.MaSv.Equals(maSv))
            {
                updateST.HoTen = hoTen;
                updateST.Tuoi = tuoi;
                updateST.GioiTinh = gioiTinh;
                updateST.DiemMh.Clear();
                foreach (var d in diem)
                {
                    updateST.themDiem(d);

                }

                Console.WriteLine("Cập nhật thành công");
                return;
            }
        }
        Console.WriteLine("Sinh viên không tồn tại");

    }

    public void deleteSV(string maSV)
    {
        foreach (var delSV in sinhVien)
        {
            if (delSV.MaSv.Equals(maSV))
            {
                sinhVien.Remove(delSV);
                Console.WriteLine("Đã xoá thành công");
                break;
            }
        }
        Console.WriteLine("Đã xoá thành công");

    }
    public void themSV(string maSv, string hoTen, int tuoi, bool gioiTinh, List<double> diem)
    {
        if (kiemTraMaSV(maSv))
        {
            Console.WriteLine("Mã sv đã tồn tại");
            return;
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

    public double diemTBSV(string masv)
    {
        var sv = sinhVien.Where(sv => sv.MaSv.Equals(masv))
            .Select(sv => sv.diemTB()).FirstOrDefault();
        return sv;
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