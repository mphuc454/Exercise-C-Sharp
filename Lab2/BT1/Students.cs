namespace Lab2;

public class Students
{
    private string mssv;
    private string nameStudent;
    private int ageStudent;
    private string genderStudent;
    private List<MonHoc> danhsachMonHoc;

    public Students(string mssv, string nameStudent, int ageStudent, string genderStudent)
    {
        this.mssv = mssv;
        this.nameStudent = nameStudent;
        this.ageStudent = ageStudent;
        this.genderStudent = genderStudent;
        this.danhsachMonHoc = new List<MonHoc>();
    }

    public string MSSV
    {
        get
        {
            if (this.mssv == null)
            {
                return "Không có mssv";
            }
            else
            {
                return this.mssv;

            }
        }
        set
        {
            this.mssv = value;
        }
    }

    public string NameStudent
    {
        get
        {
            if (this.nameStudent == null)
            {
                return "Không có tên";
            }
            else
            {
                return this.nameStudent;

            }
            
        }
        set
        {
            this.nameStudent = value;
        }
        
    }

    public int AgeStudent
    {
        get
        {
            if (this.ageStudent <= 5)
            {
                return 6;
            }
            else
            {
                return this.ageStudent;
            }
        }
    }
    public string GenderStudent
    {
        get
        {
            if (this.genderStudent == null)
            {
                return "Không có giới tính";
            }
            else
            {
                return this.genderStudent;
            }
        }
    }

    public void addMonHoc(MonHoc monHoc)
    {
        danhsachMonHoc.Add(monHoc);
    }
    public override string ToString()
    {
        return $"MSSV: {MSSV} - Tên: {NameStudent} - Tuổi: {AgeStudent} - Giới tính: {GenderStudent} ";
    }

    public void xuatDanhSachMonHoc()
    {
        Console.WriteLine($"Danh sách môn học của {this.MSSV} - ");
        foreach (MonHoc mh in danhsachMonHoc)
        {
            Console.WriteLine($"{mh}, ");
        }

        Console.WriteLine();
    }
    
}