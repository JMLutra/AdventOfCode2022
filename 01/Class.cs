using System;
using System.IO;

namespace AoC.First
{
    public class Class
    {
        public Class()
        {
            var input = File.ReadAllLines("files/01.txt");
            int most = 0;
            int secondMost = 0;
            int thirdMost = 0;
            int x = 0;
            
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i].Length != 0)
                {
                    x = x + Int32.Parse(input[i]);
                } else
                {
                    if (x > most)
                    {
                        thirdMost = secondMost;
                        secondMost = most;
                        most = x;
                        x = 0;
                    }else if(x > secondMost)
                    {
                        thirdMost = secondMost;
                        secondMost = x;
                        x = 0;
                    } else if (x > thirdMost)
                    {
                        thirdMost = x;
                        x = 0;
                    }else
                    {
                        x = 0;
                    }
                    
                }
            }
            Console.WriteLine($"Most {most} \nTop three {most + secondMost + thirdMost}");
        }
    }
}