namespace BT4;

class BT4
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập vào 1 số nguyên dương");
        string ? inputX = Console.ReadLine();
        int x = int.Parse(inputX);

        int res = 1;
        while (x >= 1)
        {
            res *= x;
            x--;
        }
        Console.WriteLine($"Giai thừa của {inputX} là {res}.");
    }
}