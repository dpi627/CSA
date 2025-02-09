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

        static string GetBankName(string first2Code)
        {
            switch (first2Code)
            {
                case "03":
                    return "此卡片為聯合信用卡";
                case "35":
                    return "此卡片為JCB信用卡";
                case "45":
                    return "此卡片為MASTER信用卡";
                case "54":
                    return "此卡片為VISA信用卡";
                default:
                    return "非本店特約用戶";
            }
        }
    }
}
