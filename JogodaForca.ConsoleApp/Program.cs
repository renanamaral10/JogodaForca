using System;

namespace JogodaForca.ConsoleApp
{
    internal class Program
    {
        static string[] palavras = { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
        static int tentativas = 5;
        static int erros = 0;
        static char[] letrasCertas;
        static List<char> letrasErradas = new List<char>();
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo da forca!");
            Console.WriteLine("Tente adivinhar a palavra secreta. Você tem " + tentativas + " tentativas.");
            string palavra = palavras[random.Next(palavras.Length)];
            letrasCertas = new char[palavra.Length];
            for (int i = 0; i < letrasCertas.Length; i++)
            {
                letrasCertas[i] = '_';
            }
            while (tentativas > 0)
            {
                Console.WriteLine();
                DesenharForca();
                Console.WriteLine("Palavra secreta: " + String.Join(" ", letrasCertas));
                Console.WriteLine("Letras erradas: " + String.Join(" ", letrasErradas));
                Console.Write("Digite uma letra: ");
                char letra = Console.ReadLine().ToUpper()[0];
                bool acertou = false;
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        letrasCertas[i] = letra;
                        acertou = true;
                    }
                }
                if (acertou)
                {
                    Console.WriteLine("Você acertou uma letra!");
                    if (!letrasCertas.Contains('_'))
                    {
                        Console.WriteLine("Parabéns, você venceu!");
                        return;
                    }
                }
                else
                {
                    letrasErradas.Add(letra);
                    Console.WriteLine("Letra errada!");
                    erros++;
                    tentativas--;
                    if (tentativas == 0)
                    {
                        Console.WriteLine("Você perdeu! A palavra secreta era " + palavra + ".");
                    }
                }
            }
        }
        static void DesenharForca()
        {
            switch (erros)
            {
                case 0:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 1:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 2:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine(" |     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 3:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 4:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 5:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("/      |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 6:
                    Console.WriteLine(" +-----+");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("/ \\    |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                default:
                    break;

            }


        }
        
    }
}