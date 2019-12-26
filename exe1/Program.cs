using System;


    class Program
    {
    int diferentes = 0;
    static void Main(string[] args)
        {
            Program pr = new Program();
        //entrada
        string[] lista = new string[] { "arara", "mussum", "maratona", "anili", "abcdef", "arar" };
        //string[] lista = new string[] { "arara","mussum","anili"};
            foreach (string palavra in lista)
            {
                pr.Print(palavra);
                pr.Palindromo(palavra);
            }
        }


        public void Print(string palavra)
        {
            Console.WriteLine(palavra);
        }
        public string Palindromo(string palavra)
    {
        int initializer = (palavra.Length / 2);
        int offset = 0;
        if (palavra.Length % 2 == 0)
        {
            Console.WriteLine("Par");
            initializer -= 1;
            offset = +1;
        }
        else
        {
            Console.WriteLine("Impar");

        }
        
        int value = PalindromoCheck(palavra, initializer, offset);
        
        Console.WriteLine("value:" + (value).ToString());
        
        
        
        return palavra;
    }

    private static int PalindromoCheck(string palavra, int initializer, int offset)
    {
        
        for (int i = initializer + 1; i < palavra.Length; i++)
        {
            if (diferentes >= palavra.Length)
            {
                diferentes = palavra.Length - offset;
            }
            Console.WriteLine("[" + i.ToString() + "]"+ palavra[i]+":[" + (initializer + (initializer - i) + offset).ToString() + "]:" + palavra[initializer + (initializer - i) + offset]);
            if (palavra[i] != palavra[(initializer + (initializer - i) + offset)])
            {
                diferentes += 1;
                Console.WriteLine(diferentes.ToString());
                PalindromoCheck(palavra, initializer + 1, offset, diferentes);
            }
        }
        Console.WriteLine("callback");
        return diferentes;
    }
}

