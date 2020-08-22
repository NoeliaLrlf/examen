using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Account
    {
        public static int MinimumBalance { get; set; } = 100;
        public string ids;
        public static List<string> id = new List<string>();

        public static int count;

        public static int Count
        {
            get => count;
        }

        public static string Ids
        {
            get => string.Join(",", id);
        }

        public Account(string ids)
        {
            count++;
            id.Add(ids);
        }
    }
}