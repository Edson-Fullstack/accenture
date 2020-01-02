using System;

namespace exe1
{
    public class Program
    {

        static void Main(string[] args)
        {
            //fix para main static
            Program pr = new Program();
            //ENTRADA lista de testes
            string[] lista = new string[] { "arara", "mussum", "maratona", "anili", "abcdef", "arar", "aaaaa" };
            //string[] lista = new string[] { "arara","mussum","anili"};

            //loop para interação com lista de strings definida
            foreach (string palavra in lista)
            {
                //analise de contagem de palindromos
                pr.PalindromoCount(palavra);
            }
        }

        //função para vizualizar os valores
        public void Print(string palavra)
        {
            Console.WriteLine(palavra);
        }

        public int PalindromoCount(string palavra)
        {
            int count = 0;//contador para o numero de hits na string
            char buffer = ' ';//buffer que armazena ultima string repetida i conta caso exista valores repetidos

            //loop que se modifica no inicio a cada interação e no final caso os valore forem iguais
            for (int start = 0, end = palavra.Length - 1; start <= end; ++start)
            {
                //caso string atual é igual ao buffer e diferentes do end
                if (buffer == palavra[start] && palavra[start] != palavra[end])
                {
                    //adiciona 2 a contagem pelas 2 casas atuais
                    count += 2;
                }
                //Print(buffer.ToString()); 
                //Print(palavra[start].ToString() + palavra[end].ToString() + count);

                //caso inicio é igual ao final coloca palavra no buffer e diminiu a pilha
                if (palavra[start] == palavra[end])
                {
                    buffer = palavra[start];
                    end--;
                }
                //se forem diferentes adiciona 1 ao contador
                else
                {
                    count++;
                }
            }
            //Saida
            Print("Entrada:" + palavra + "                  Saida:" + count.ToString());
            return count;
        }
    }
}