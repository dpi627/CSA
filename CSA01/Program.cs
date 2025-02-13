﻿using System;

namespace CSA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("請輸入信用卡號碼前兩碼> ");
                string input = Console.ReadLine();
                string output;
                if (IsValid(input))
                {
                    output = GetBank(input) + GetArea(input);
                }
                else
                {
                    output = "輸入錯誤，請重新輸入";
                }
                Console.WriteLine($"{output}{Environment.NewLine}");
            }
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

        static bool IsValid(string first2Code)
        {
            if (first2Code.Length != 2)
            {
                return false;
            }

            if (int.TryParse(first2Code, out int code))
            {
                return code >= 0 && code <= 99;
            }
            return false;
        }
    }
}
