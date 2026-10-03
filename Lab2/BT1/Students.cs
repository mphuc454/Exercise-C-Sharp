namespace Lab2;

public class Students
{
    private string maSV;
    private string hoTen;
    private int tuoi;
    private bool gioiTinh;
    private List<double> diemMH = new List<double>();

    public Students()
    {
    }

    public Students(string maSv, string hoTen, int tuoi, bool gioiTinh)
    {
        this.maSV = maSv;
        this.hoTen = hoTen;
        this.tuoi = tuoi;
        this.gioiTinh = gioiTinh;
    }

    public string MaSv
    {
        get => maSV;
        set => maSV = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string HoTen
    {
        get => hoTen;
        set => hoTen = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Tuoi
    {
        get => tuoi;
        set => tuoi = value;
    }

    public bool GioiTinh
    {
        get => gioiTinh;
        set => gioiTinh = value;
    }
    public void themDiem(double diem)
    {
        if (diem >= 0 || diem <= 10)
        {
            diemMH.Add(diem);
        }
        else
        {
            Console.WriteLine("Điểm không hợp lệ ");
        }
    }

    public string xuatDiem()
    {
        return string.Join(", ", diemMH);
    }
    public override string ToString()
    {
        string gioitinh = (GioiTinh) ? "NỮ" : "NAM";
        return $"MSSV: {MaSv} - Tên: {HoTen} - Tuổi: {Tuoi} - Giới tính: {gioitinh} - Điểm:[ {xuatDiem()} ]";
    }
}
    