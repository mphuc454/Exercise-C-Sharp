namespace BT5;

class BT5
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("Nhập vào 1 số nguyên dương bán kính R");
        string ? inputR = Console.ReadLine();
        int r = int.Parse(inputR);
        
        double chuviHinhTron = 2 * r * 3.14;
        Console.WriteLine($"Chu vi Hình Tròn {chuviHinhTron}");
        double dienTichHinhTron = Math.Pow(r, 2) * 3.14;
        Console.WriteLine($"Diện tích Hình Tròn {dienTichHinhTron}");
        
        Console.WriteLine("Nhập vào 1 số nguyên dương cạnh a");
        string ? inputA = Console.ReadLine();
        int a = int.Parse(inputA);
        Console.WriteLine("Nhập vào 1 số nguyên dương cạnh b");
        string ? inputB = Console.ReadLine();
        int b = int.Parse(inputB);
        Console.WriteLine("Nhập vào 1 số nguyên dương cạnh c");
        string ? inputC = Console.ReadLine();
        int c = int.Parse(inputC);
        Console.WriteLine("Nhập vào 1 số nguyên dương chiều cao h");
        string ? inputH = Console.ReadLine();
        int h = int.Parse(inputH);
        
        double chuviTamGiac = a + b + c;
        Console.WriteLine($"Chu vi Tam Giác {chuviTamGiac}");
        double dienTichTamGiac = (a * h) / 2.0;
        Console.WriteLine($"Diện tích Tam giác {dienTichTamGiac}");
        
        Console.WriteLine("Nhập vào 1 số nguyên dương dài ");
        string ? inputX = Console.ReadLine();
        int x = int.Parse(inputX);
        Console.WriteLine("Nhập vào 1 số nguyên dương rộng");
        string ? inputY = Console.ReadLine();
        int y = int.Parse(inputY);

        double chuviHCN = (x + y) * 2;
        Console.WriteLine($"Chu vi HCN {chuviHCN}");
        double dienTichHCN = x * y;
        Console.WriteLine($"Diện tích HCN {dienTichHCN}");
    }
}