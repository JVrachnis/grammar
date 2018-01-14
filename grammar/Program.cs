using System;
using System.Collections.Generic;
namespace Grammar
{
    class Program
    {
        static string[] ekfrasi = { "<oros>", "<ekfrasi> + <oros>" };
        static string[] oros = { "<paragontas>", "<oros> * <paragontas>" };
        static string[] paragontas = { "a", "b", "c" };
        static Dictionary<string, string[]> grammar = new Dictionary<string, string[]>();
        static string input = "<ekfrasi>";
        static Random r = new Random();
        static void Main(string[] args)
        {
            grammar.Add("<ekfrasi>", ekfrasi);
            grammar.Add("<oros>", oros);
            grammar.Add("<paragontas>", paragontas);
            while (input.Contains("<"))
            {
                foreach (string Key in grammar.Keys)
                {
                    int place = -1;
                    while (input.Contains(Key))
                    {
                        Console.WriteLine(input+"  =>");
                        place = input.LastIndexOf(Key);
                        input = input.Remove(place, Key.Length).Insert(place, grammar[Key][r.Next(grammar[Key].Length)]);
                    }
                }
            }
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
