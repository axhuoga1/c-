using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 随机数生成器
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // 生成 1 到 100 之间的随机数
            int guess = 0; // 玩家猜测的数字
            int attempts = 0; // 猜测次数

            Console.WriteLine("欢迎来到猜数字游戏！");
            Console.WriteLine("我已经想好了一个 1 到 100 之间的数字。你能猜出来吗？");

            // 游戏主循环
            while (guess != targetNumber)
            {
                Console.Write("请输入你的猜测：");
                
                // 尝试将输入转换为整数
                try
                {
                    guess = int.Parse(Console.ReadLine());
                    attempts++; // 每次输入都算一次尝试

                    // 检查玩家的猜测
                    if (guess > targetNumber)
                    {
                        Console.WriteLine("太大了！");
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("太小了！");
                    }
                    else
                    {
                        Console.WriteLine($"恭喜你，猜对了！你一共猜了 {attempts} 次。");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("请输入一个有效的数字！");
                }
            }

            Console.WriteLine("游戏结束，谢谢你玩这个游戏！");
        }
    }
}
