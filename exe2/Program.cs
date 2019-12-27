using System;
using System.Collections.Generic;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //fix para main static
            Program pr = new Program();
            //ENTRADA nome do rei
            string[] kings = new string[] { "Louis IX", "Louis VIII" };
            pr.KingSort(kings);
        }

        public void Print(string palavra)
        {
            Console.WriteLine(palavra);
        }
        public void KingSort(string[] kings)
        {

            for (int i=0;i<kings.Length;i++)
            {
                string[] set = kings[i].Split(' ');
                
                Print(set[0]);
                Print(set[1]);
                Print(SimplerConverter(set[1]).ToString());
            }

        }
        public int SimplerConverter(string number)
        {
            number = number.ToUpper();
            var result = 0;
            foreach (var letter in number)
            {
                result += ConvertLetterToNumber(letter);
            }
            if (number.Contains("IV") || number.Contains("IX"))
                result -= 2;
            if (number.Contains("XL") || number.Contains("XC"))
                result -= 20;
            if (number.Contains("CD") || number.Contains("CM"))
                result -= 200;
            return result;
        }
        private int ConvertLetterToNumber(char letter)
        {
            switch (letter)
            {
                case 'M':
                    {
                        return 1000;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'V':
                    {
                        return 5;
                    }

                case 'I':
                    {
                        return 1;
                    }

                default:
                    {
                        throw new ArgumentException("Ivalid charakter");
                    }



            }

        }
    }
}
