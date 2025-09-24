using System;

namespace ch16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();

            // 輸入身高(公尺)
            Console.Write("請輸入身高(公分): ");
            double heightCm = Convert.ToDouble(Console.ReadLine());
            double height = heightCm / 100;

            // 輸入體重(公斤)
            Console.Write("請輸入體重(公斤): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // 計算 BMI
            double bmi = weight / (height * height);

            // 輸出結果
            Console.WriteLine("您的BMI值為: " + bmi);
        }
            }

        }
