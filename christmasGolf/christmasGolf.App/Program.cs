using System;
using System.Collections.Generic;

namespace christmasGolf.App
{
    class Program
    {
        static void Main()
        {
            List<string> days = new List<string>() { "first", "second", "thrid", "fourth", "fifth", "sixth", "seventh", "eigth", "ninth", "tenth", "eleventh", "twelth" };
            string intro = "On the {0} day of Christmas,\nmy true love sent to me";
            foreach (var d in days)
            {
                //Console.WriteLine(intro, d);
            }
            List<string> thePeculiaritiesOfChristmas = new List<string>() { "And a partridge in a pear tree.\n", "Two turtle doves,", "Three french hens,", "Four calling birds,", "Five golden rings,", "Six geese a-laying,", "Seven swans a-swimming", "Eight maids a milking,", "Nine ladies dancing,", "Ten lords a-leeping", "Elven pipers piping", "Twelve drummers drumming," };
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(intro, days[i]);
                int c = i;
                
                while (c >= 0)
                {
                    if(i == 0)
                    {
                        Console.WriteLine("A partridge in a pair tree\n");
                        c--;
                        continue;
                    }

                    Console.WriteLine(thePeculiaritiesOfChristmas[c]);
                    c--;
                }
                
            }
        }
    }
}
