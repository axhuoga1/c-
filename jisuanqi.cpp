using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 欢迎信息
            Console.WriteLine("欢迎使用简易计算器！");
            Console.WriteLine("----------------------");

            // 输入第一个数字
            Console.Write("请输入第一个数字: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // 输入运算符
            Console.Write("请输入运算符 (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // 换行

            // 输入第二个数字
            Console.Write("请输入第二个数字: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            // 执行运算
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("错误：除数不能为零！");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("无效的运算符！");
                    validOperation = false;
                    break;
            }

            // 输出结果
            if (validOperation)
            {
                Console.WriteLine($"结果: {num1} {operation} {num2} = {result}");
            }

            Console.WriteLine("谢谢使用，再见！");
        }
    }
