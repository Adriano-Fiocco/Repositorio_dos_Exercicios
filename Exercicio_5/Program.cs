namespace Exercicio_5;
class Program
{
    static void Main(string[] args)
    {
        string texto;
        int tamanho;
        char[] caracteres;

        Console.WriteLine("Digite uma palavra ou frase ou número!!!");
        texto = Console.ReadLine();

        caracteres = texto.ToCharArray();
        tamanho = caracteres.Length;

        char[] inverter = new char[tamanho];

        Console.WriteLine("==== A palavra ou frase ou número invertido ====");

        for(int i = 0; i < tamanho; i++)
        {
            inverter[i] = caracteres[tamanho -1 - i];
            Console.Write(inverter[i]);
        }
    }
}
