namespace BT2;

class BT2
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập vào 1 số nguyên dương từ 100 đến 999) và có phải là số amstrong không.");
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
            double sum = Math.Pow(tram, 3) + Math.Pow(chuc, 3) + Math.Pow(donvi, 3);
            if (sum == num)
            {
                Console.WriteLine("Là số Amstrong");
            }
            else
            {
                Console.WriteLine("Không phải số Amstrong");

            }
            
        }

    }
}