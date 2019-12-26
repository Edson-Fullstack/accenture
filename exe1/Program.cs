using System;

namespace exe1
{
    class Program
    {

        static void Main(string[] args)
        {
            Program pr = new Program();
            //entrada
            string[] lista = new string[] { "arara", "mussum", "maratonab", "anili", "abcdef", "arar" };
            //string[] lista = new string[] { "arara","mussum","anili"};
            foreach (string palavra in lista)
            {
                pr.PalindromoCount(palavra);
            }
        }


        public void Print(string palavra)
        {
            Console.WriteLine(palavra);
        }
   
        public string PalindromoCount(string palavra)
        {
            int count = 0;
            Print(palavra.ToString());
            for (int start = 0, end = palavra.Length - 1; start <= end; start++)
            {
                Print(palavra[start].ToString() + palavra[end].ToString() + count);
                if (palavra[start] != palavra[end])
                {
                    count++;
                }
                else
                {
                    end--;
                }
            }
            Print("Value:"+count.ToString());
            return palavra;
        }


    }
}