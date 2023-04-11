
using Newtonsoft.Json;

namespace Exercicio_3;
class Program
{
    static void Main(string[] args)
    {
        double menorValor;
        double maiorValor;
        double soma = 0;
        double media;
        int contador = 0;
        int dia = 0;

        string json = File.ReadAllText(@"C:\Users\adria\OneDrive\Área de Trabalho\Exercicios_teste\dados.json");

        var dados = JsonConvert.DeserializeObject<Dado[]>(json);

        menorValor = dados[0].valor;
        
        for(int i = 1; i < dados.Length; i++)
        {
            if(dados[i].valor !=0 && dados[i].valor < menorValor)
            {
                menorValor = dados[i].valor;
                dia = dados[i].dia;
            }
        }
        Console.WriteLine($"O menor valor de faturamento foi no dia {dia} com valor R${menorValor}. Tirando os dias aonde o faturamento foi Zero.");
        
        maiorValor = dados[0].valor;

        for(int i = 1; i < dados.Length; i++)
        {
            if(dados[i].valor > maiorValor)
            {
                maiorValor = dados[i].valor;
                dia = dados[i].dia;
            }
        }
        Console.WriteLine($"O maior valor de faturamento foi no dia {dia} com valor R${maiorValor}.");
        

        foreach (var dado in dados)
        {
            if(dado.valor != 0)
            {
                soma += dado.valor;
                contador = contador +1;
            }
        }

        media = soma/contador;

        contador = 0;

        foreach(var dado in dados)
        {
            if(dado.valor > media)
            {
                contador = contador + 1;
            }
        }
       Console.WriteLine($"No mês teve {contador} dias aonde o faturamento diário superou a média mensal de R${media:F2}.");
        
    }
    class Dado
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
}
