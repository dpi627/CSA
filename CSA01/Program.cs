using System;

namespace CSA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入信用卡號碼前兩碼: ");
            var first2Code = Console.ReadLine();
            Console.WriteLine(first2Code);
        }
    }
}
