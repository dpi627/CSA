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

        static string GetBank(string first2Code)
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

        static string GetArea(string first2Code)
        {
            int code = int.Parse(first2Code);
            if (code >= 30 && code <= 39)
            {
                return "(大中華區)";
            }
            else if (code >= 40 && code <= 49)
            {
                return "(歐美地區)";
            }
            else
            {
                return "";
            }
        }
    }
}
