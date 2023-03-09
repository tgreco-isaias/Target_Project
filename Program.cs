using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Target_Project.Distribuidora;

namespace Target_Project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			////EXERCICIO 1
			Console.WriteLine("----- Executando o primeiro loop -----");
			int INDICE = 13, SOMA = 0, K = 0;

			while (K < INDICE)
			{
				K = K + 1;
				SOMA = SOMA + K;
			}

			Console.WriteLine("O resultado do primeiro loop é: " + SOMA);

			// //EXERCICIO 2
			Console.WriteLine("----- Executando o segundo loop -----");

			Console.Write("Digite um número inteiro: ");
			int num = int.Parse(Console.ReadLine());

			int a = 0, b = 1, c = 0, count = 0;
			while (c < num)
			{
				c = a + b;
				a = b;
				b = c;
				count++;
			}

			if (c == num)
			{
				Console.WriteLine(num + " pertence à sequência de Fibonacci.");
			}
			else
			{
				Console.WriteLine(num + " não pertence à sequência de Fibonacci.");
			}

			Console.ReadLine(); // espera o usuário pressionar Enter



			////EXERCICIO 3

			string json = @"[
                {
                    ""dia"": 1,
                    ""valor"": 22174.1664
                },
                {
                    ""dia"": 2,
                    ""valor"": 24537.6698
                },
                {
                    ""dia"": 3,
                    ""valor"": 26139.6134
                },
                {
                    ""dia"": 4,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 5,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 6,
                    ""valor"": 26742.6612
                },
                {
                    ""dia"": 7,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 8,
                    ""valor"": 42889.2258
                },
                {
                    ""dia"": 9,
                    ""valor"": 46251.174
                },
                {
                    ""dia"": 10,
                    ""valor"": 11191.4722
                },
                {
                    ""dia"": 11,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 12,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 13,
                    ""valor"": 3847.4823
                },
                {
                    ""dia"": 14,
                    ""valor"": 373.7838
                },
                {
                    ""dia"": 15,
                    ""valor"": 2659.7563
                },
                {
                    ""dia"": 16,
                    ""valor"": 48924.2448
                },
                {
                    ""dia"": 17,
                    ""valor"": 18419.2614
                },
                {
                    ""dia"": 18,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 19,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 20,
                    ""valor"": 35240.1826
                },
                {
                    ""dia"": 21,
                    ""valor"": 43829.1667
                },
                {
                    ""dia"": 22,
                    ""valor"": 18235.6852
                },
                {
                    ""dia"": 23,
                    ""valor"": 4355.0662
                },
                {
                    ""dia"": 24,
                    ""valor"": 13327.1025
                },
                {
                    ""dia"": 25,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 26,
                    ""valor"": 0.0
                },
                {
                    ""dia"": 27,
                    ""valor"": 25681.8318
                },
                {
                    ""dia"": 28,
                    ""valor"": 1718.1221
                },
                {
                    ""dia"": 29,
                    ""valor"": 13220.495
                },
                {
                    ""dia"": 30,
                    ""valor"": 8414.61
                }
            ]";

			List<DiaFaturamento> faturamentoMensal = JsonConvert.DeserializeObject<List<DiaFaturamento>>(json);

			var menorValorFaturamento = faturamentoMensal.OrderBy(f => f.valor).First();
			var maiorValorFaturamento = faturamentoMensal.OrderByDescending(f => f.valor).First();

            var mediaMensal = faturamentoMensal.Sum(f => f.valor) / faturamentoMensal.Count();

            var diasFaturamentoSuperiorMedia = faturamentoMensal.Count(f => f.valor > mediaMensal);

			Console.WriteLine("O menor faturamento foi: " + menorValorFaturamento.valor);
			Console.WriteLine("O maior faturamento foi: " + maiorValorFaturamento.valor);
			Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: " + diasFaturamentoSuperiorMedia);

			Console.ReadKey();

			//EXERCICIO 4

			decimal spFaturamento = 67836.43m;
			decimal rjFaturamento = 36678.66m;
			decimal mgFaturamento = 29229.88m;
			decimal esFaturamento = 27165.48m;
			decimal outrosFaturamento = 19849.53m;

			decimal faturamentoTotal = (spFaturamento + rjFaturamento + mgFaturamento + esFaturamento + outrosFaturamento);

			decimal spPercentual = (spFaturamento / faturamentoTotal) * 100m;
			decimal rjPercentual = (rjFaturamento / faturamentoTotal) * 100m;
			decimal mgPercentual = (mgFaturamento / faturamentoTotal) * 100m;
			decimal esPercentual = (esFaturamento / faturamentoTotal) * 100m;
			decimal outrosPercentual = (outrosFaturamento / faturamentoTotal) * 100m;

			Console.WriteLine($"Percentual de representação do faturamento por estado:");
			Console.WriteLine($"SP: {spPercentual:F2}%");
			Console.WriteLine($"RJ: {rjPercentual:F2}%");
			Console.WriteLine($"MG: {mgPercentual:F2}%");
			Console.WriteLine($"ES: {esPercentual:F2}%");
			Console.WriteLine($"Outros: {outrosPercentual:F2}%");

            Console.ReadKey();


            // EXERCICIO 5
			Console.WriteLine("Entre com o texto que deseja reverter: ");

			string texto = Console.ReadLine();

			var textoRevertido = "";

			for (int i = 1; i < texto.Length + 1; i++)
			{
				textoRevertido += texto[texto.Length - i];
			}

			Console.WriteLine("O texto revertido é: " + textoRevertido);

			Console.ReadKey();

		}


    }
}
		











