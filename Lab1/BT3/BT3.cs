namespace BT3;

class BT3
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập vào 1 số nguyên dương");
        string ? inputX = Console.ReadLine();
        Console.WriteLine("Nhập vào 1 số luỹ thừa nguyên dương");
        string ? inputN = Console.ReadLine();
        int x = int.Parse(inputX);
        int n = int.Parse(inputN);
        int res = 1;
        for (int i = 1; i <= n; i++)
        {
            res *= x;
        }

        Console.WriteLine($"Giá trị {x} lũy thừa {n} là: {res}.");

    }
}