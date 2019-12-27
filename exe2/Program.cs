using System;
using System.Collections.Generic;
using System.Linq;

namespace exe2
{
    //cada rei contem Nome
    //Ordinal I,V,X
    //e Numeral 12345
    public class King
    {
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public string Numeral { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //fix para main static
            Program pr = new Program();
            //ENTRADA nome do rei e testes para todas as entradas apresentadas
            string[] kings = new string[] { "Louis IX", "Louis VIII" };//pass
            //string[] kings = new string[] { "Louis IX", "Philippe II" };//pass
            //string[] kings = new string[] { "Richard III", "Richard I", "Richard II" };//pass
            //string[] kings = new string[] { "John X", "John I", "John L", "John V" };//pass
            //string[] kings = new string[] { "Philippe VI", "Jean II", "Charles V", "Charles VI", "Charles VII", "Louis XI" };//pass
            //string[] kings = new string[] { "Philippe II", "Philip II" };//pass
            pr.GetSortedList(kings);
        }
        //methodo de print generico
        public void Print(string palavra)
        {
            Console.WriteLine(palavra);
        }
        //methodo para printar um rei
        public void PrintKing(King k)
        {
            Console.WriteLine(k.Name + k.Ordinal + "-" + k.Numeral);
        }
        //função para objeter a lista de reis ordenada
        public string[] GetSortedList(string[] kings)
        {
            //utiliza o Ilist pois pode armazenar objetos e possui os metodos orderby e thenby
            IList <King> kingss=new King[kings.Length];
            King k;
            //gera a lista com os reis
            for (int i = 0; i < kings.Length; i++)
            {
                string[] set = kings[i].Split(' ');
                k = new King { Name = set[0], Ordinal = SimplerConverter(set[1]), Numeral = set[1] };
                kingss[i]=k;
            }
            Print("Order:");
            //aplica o methodo para obter a ordenação descrita
            var kk=kingss.OrderBy(King => King.Name).ThenBy(King => King.Ordinal);
            string[] kingsOrder;
            foreach (King ki in kk)
            {
                Console.WriteLine("{0} - {1}", ki.Name, ki.Numeral);

            }
            return kings;
        }
        //Converte o valor Romano para int
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
        //auxilia na conversão para int
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
