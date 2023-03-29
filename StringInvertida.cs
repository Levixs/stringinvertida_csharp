using System;

namespace StringInvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a string que deseja inverter: ");
            string entrada = Console.ReadLine();

            // converte a string para um array de caracteres
            char[] chars = entrada.ToCharArray();

            // inverte a ordem dos caracteres da string informada
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            // converte o array de caracteres de volta para uma string
            string invertida = new string(chars);

            // mostra a string invertida na tela
            Console.WriteLine("String invertida: " + invertida);
            Console.ReadKey();
        }
    }
}
