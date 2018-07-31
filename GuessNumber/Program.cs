using System;
class Program
{
    static void Main(string[] args)
    {
        int TargetNumber;

        TargetNumber = (int)(new Random().NextDouble() * 100 + 1);

        Console.WriteLine("從1到100共100個整數範圍的任意一個整數   為");
        Console.WriteLine(TargetNumber);

        Console.WriteLine("--------------------------------------");
        String InputNumber;
        int GuessNumber;
        bool TransCheck, BingGO = false;

        while (!BingGO)
        {
            Console.WriteLine();
            Console.WriteLine("請輸入一個從1到100的整數");
            InputNumber = Console.ReadLine();
            TransCheck = int.TryParse(InputNumber, out GuessNumber);
            if (TransCheck)
            {
                Console.Write("你猜的數字為 ");
                Console.WriteLine(GuessNumber);
                if (GuessNumber > TargetNumber)
                {
                    Console.WriteLine("Smaller");
                }
                else if (GuessNumber < TargetNumber)
                {
                    Console.WriteLine("Bigger");
                }
                else
                {
                    Console.WriteLine("恭喜你猜中啦!");
                    BingGO = true;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("遊戲結束");
        Console.WriteLine();
        Console.ReadKey();
    }
}

