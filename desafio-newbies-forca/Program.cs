using System;
using System.Reflection;
using System.Text;

public class Program
{
    public static void Main()
    {
        string[] palavras = { "pinheiro", "saudades", "protocolo", "linguagem", "ovelha", "caderno", "teclado", "copo", "cobertor", "inteligente" };
        var random = new Random();
        int indicePalavras = random.Next(palavras.Length);
        string palavra = palavras[indicePalavras];

        string palavraEscondida = "";
        for (int i = 0; i < palavra.Length; i++)
        {
            palavraEscondida += "_";
        }

        Console.WriteLine("Bem vindo(a) ao jogo da forca!");

        StringBuilder palavraEscondidaString = new StringBuilder(palavraEscondida);

        char[] arrayPalavra = palavra.ToCharArray();

        while (palavraEscondida != palavra)
        {
            Console.WriteLine($"Adivinhe uma letra da palavra: {palavraEscondida}");
            string letraAdivinhada = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                if (arrayPalavra[i] == letraAdivinhada[0])
                {
                    palavraEscondidaString[i] = letraAdivinhada[0];
                }
            }

            palavraEscondida = palavraEscondidaString.ToString();
        }

        Console.WriteLine($"Parabéns, você acertou! A palavra completa é: {palavraEscondida}");
    }
}