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
            pr.GetSortedList(kings);
        }

        public void Print(string palavra)
        {
            Console.WriteLine(palavra);
        }
        public void PrintKing(string name,string rnumeral,int numeral)
        {
            Console.WriteLine(name+ rnumeral+"-"+numeral);
        }
        public string[] GetSortedList(string[] kings)
        {
            string[] names = new string[kings.Length];
            string[] ordinal = new string[kings.Length];
            int[] numeral = new int[kings.Length];
            for (int i=0;i<kings.Length;i++)
            {
                string[] set = kings[i].Split(' ');
                int j = i;
                while (set[j].CompareTo(names[i]) < 0)
                {
                    Print(j.ToString());
                }
                names[i] = set[0];
                ordinal[i] = set[1];
                numeral[i] = SimplerConverter(set[1]);
                PrintKing(names[i],ordinal[i],numeral[i]);
            }
            return kings;
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
