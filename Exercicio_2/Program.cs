namespace Exercicio_2;
class Program
{
    static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 1;
        int soma = 0;
        int n;
        

        Console.WriteLine("Digite um número para verificar se ele esta na sequência de Fibonacci");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write(n1 + " " + n2 + " ");
        for(int i = 2 ; i < n; i++)
        {
            soma = n1 + n2;
            Console.Write(soma + " ");
            n1 = n2;
            n2 = soma;

            if(soma == n)
            {
                Console.WriteLine($"\nO número {n} está na sequência de Fibonacci.");
                break;
            }
            else if(soma > n)
            {
                Console.WriteLine($"\nO número {n} não está na sequência de Fibonacci.");
                break;
            }
        }

        


    }
}
