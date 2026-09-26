namespace BT6;

class BT6
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] nums = {6,10,5,-8,0,1,2,-23,26,9};
        double sum = 0;
        double sumChan = 0;
        double sumLe = 0;
        int maxNum = nums[0];
        int minNum = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        for (int i = 0; i <  nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                sumChan++;
            }
            else if(nums[i] % 2 != 0)
            {
                sumLe++;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxNum)
            {
                maxNum = nums[i];
            }else if (nums[i] < minNum)
            {
                minNum = nums[i];
            }
            
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length -i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    
                }
            }
            
        }
        Console.WriteLine($"Tổng các phần tử trong mảng {sum}");
        Console.WriteLine($"Đếm số phần tử chẵn {sumChan}");
        Console.WriteLine($"Đếm số phần tử lẻ {sumLe}");
        Console.WriteLine($"Phần tử lớn nhất {maxNum}");
        Console.WriteLine($"Phần tử nhỏ nhất {minNum}");
        Console.WriteLine($"Sắp xếp mảng tăng dần {nums}");
        Console.WriteLine($"Sắp xếp mảng giảm dần {minNum}");
    }
}