namespace Lab2;

public class MonHoc
{
    private string nameSubject;
    private double gpaSubject;

    public MonHoc(string nameSubject, double gpaSubject)
    {
        this.nameSubject = nameSubject;
        this.gpaSubject = gpaSubject;
    }
    public string NameSubject
    {
        get
        {
            if (this.nameSubject == null)
            {
                return "Không có tên";
            }
            else
            {
                return this.nameSubject;


            }
        }
    }
    public double GPASubject
    {
        get
        {
            if (this.gpaSubject < 0)
            {
                return 0;
            }
            else
            {
                return this.gpaSubject;
                
            }
        }
    }
    public override string ToString()
    {
        return $"Tên môn học: {this.nameSubject}";
    }
}