using System;

class Program
{
    static void Main()
    {
        string[] choices = { "石头", "剪刀", "布" };
        Random random = new Random();
        bool playAgain = true;

        Console.WriteLine("欢迎来到石头剪刀布游戏！");

        while (playAgain)
        {
            Console.WriteLine("\n请输入你的选择 (石头, 剪刀, 布): ");
            string playerChoice = Console.ReadLine();

            if (!Array.Exists(choices, element => element == playerChoice))
            {
                Console.WriteLine("无效的选择，请选择 '石头', '剪刀' 或 '布'.");
                continue;
            }

            string computerChoice = choices[random.Next(choices.Length)];
            Console.WriteLine($"电脑选择了: {computerChoice}");

            if (playerChoice == computerChoice)
            {
                Console.WriteLine("平局！");
            }
            else if ((playerChoice == "石头" && computerChoice == "剪刀") ||
                     (playerChoice == "剪刀" && computerChoice == "布") ||
                     (playerChoice == "布" && computerChoice == "石头"))
            {
                Console.WriteLine("你赢了！");
            }
            else
            {
                Console.WriteLine("你输了！");
            }

            Console.WriteLine("再来一局吗？(y/n): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "y";
        }

        Console.WriteLine("谢谢游玩，再见！");
    }
}
