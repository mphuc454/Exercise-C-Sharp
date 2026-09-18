namespace Lab1;

public class BT1
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập 1 số nguyên dương trong khoảng 100-999.");
        string ? input = Console.ReadLine();
        int num = int.Parse(input);
        if (num < 100 || num > 999)
        {
            Console.WriteLine("Vui lòng nhập số từ 100 đến 999");
        }
        else
        {   
            int tram = num / 100;
            int chuc = num / 10 % 10;
            int donvi = num % 10;
            Console.WriteLine($"Số {num} có: {tram} trăm {chuc} chục {donvi} đơn vị");   
        }
       

    }
}