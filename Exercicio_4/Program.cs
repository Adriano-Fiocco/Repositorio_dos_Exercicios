namespace Exercicio_4;
class Program
{
    static void Main(string[] args)
    {
        double perSP;
        double perRJ;
        double perMG;
        double perES;
        double perOutros;
        double total = 180759.98;

        perSP = (67836.43/total)*100;
        perRJ = (36678.66/total)*100;
        perMG = (29229.88/total)*100;
        perES = (27165.48/total)*100;
        perOutros = (19849.53/total)*100;

        Console.WriteLine($"O estado SP representa {perSP:F2}% do valor total de {total} mensal da distriuidora.");
        Console.WriteLine($"O estado RJ representa {perRJ:F2}% do valor total de {total} mensal da distriuidora.");
        Console.WriteLine($"O estado MG representa {perMG:F2}% do valor total de {total} mensal da distriuidora.");
        Console.WriteLine($"O estado ES representa {perES:F2}% do valor total de {total} mensal da distriuidora.");
        Console.WriteLine($"Os Outros estados representam {perOutros:F2}% do valor total de {total} mensal da distriuidora.");
    }
}
