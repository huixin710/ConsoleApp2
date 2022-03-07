using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = Console.ReadLine();
            Console.WriteLine("輸入："+c);
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            var cost = (meal_cost + tip_percent + tax_percent);
            Console.WriteLine("用餐總費用：" +cost);

        }
    }
}
