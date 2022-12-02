using projetoTargetSistemas.Models;
using Newtonsoft.Json;
using System.Globalization;
////===============================================
/*
1) Resposta: 91;
Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}

imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA?
*/

// int INDICE = 13, SOMA = 0, K = 0;
// while (K < INDICE)
// {
// K = K + 1;
// SOMA = SOMA + K;
// }
// Console.WriteLine(SOMA);
////===============================================
/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

*/

// Console.Write("Digite um número para a sequência: ");
// int numeroSequencia = Convert.ToInt32(Console.ReadLine());

// int termo1 = 0;
// int termo2 = 1;
// Console.Write($"{termo1}, {termo2}");

// int count = 3;
// bool pertence = false;

// while (count <= numeroSequencia)
// {
//     int termo3 = termo1 + termo2;
//     Console.Write($", {termo3}");
//     termo1 = termo2;
//     termo2 = termo3;
//     count += 1;
//     if (termo3 == numeroSequencia)
//     {
//         pertence = true;
//     }
// }
// Console.WriteLine("");
// Console.WriteLine($"O número informado para verificar se pertence ou não é {numeroSequencia}");
// Console.WriteLine(pertence ? "O número PERTENCE á sequência" : "O número NÃO PERTENCE á sequência");
// ===============================================
/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

*/
// String conteudoArquivo = File.ReadAllText("Arquivos/dados.json");
// List<Dado> listaVenda = JsonConvert.DeserializeObject<List<Dado>>(conteudoArquivo);

// int menorValorDia = 0;
// int maiorValorDia = 0;
// int quantidadeDiasMaioresFaturamento = 0;
// int quantidadeDiasFaturamento = 0;
// decimal valorTotal = 0;
// decimal maiorValor = 0;
// decimal menorValor = 0;
// decimal mediaMensal = 0;

// foreach (Dado dado in listaVenda)
// {
//     valorTotal += dado.Valor;
//     if (dado.Valor != 0)
//     {  
//         quantidadeDiasFaturamento++;
//     }
//     if (dado.Valor > maiorValor)
//     {
//         maiorValor = dado.Valor;
//         maiorValorDia = dado.Dia;
//     }
//     if (dado.Dia == 1)
//     {
//         menorValor = dado.Valor;
//     }
//     if (dado.Valor <= menorValor && dado.Valor != 0)
//     {
//         menorValor = dado.Valor;
//         menorValorDia = dado.Dia;
//     }
//     // calculando media mensal
//     mediaMensal = valorTotal / quantidadeDiasFaturamento;
//     if (dado.Valor >= mediaMensal)
//     {
//         quantidadeDiasMaioresFaturamento++;
//     }
// }
// Console.WriteLine($"Dia {menorValorDia} ocorreu o menor faturamento do mês, faturamento de: {menorValor.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Dia {maiorValorDia} ocorreu o maior faturamento do mês, faturamento de: {maiorValor.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"No mês, tiveram {quantidadeDiasMaioresFaturamento} dias, que o faturamento foi maior que a média mensal - Média mensal:{mediaMensal.ToString("C", CultureInfo.CurrentCulture)}");
// ===============================================
/*
4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

*/
// double sp = 67836.43;
// double rj = 36678.66;
// double mg = 29229.88;
// double es = 27165.48; 
// double outros = 19849.53; 

// double faturamentoTotal = sp + rj + mg + es + outros;

// double porcentagemSP = (sp * 100) / faturamentoTotal;
// double porcentagemRJ = (rj * 100) / faturamentoTotal;
// double porcentagemMG = (mg * 100) / faturamentoTotal;
// double porcentagemES = (es * 100) / faturamentoTotal;
// double porcentagemOTS = (outros * 100) / faturamentoTotal;

// Console.WriteLine("Percentual de representação de cada estado dentro do valor total da distribuidora");
// Console.WriteLine($"O faturamento total da distribuidora é {faturamentoTotal.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Porcentagem de faturamento mensal de SP foi de: {porcentagemSP.ToString("0")}% - Valor {sp.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Porcentagem de faturamento mensal de RJ foi de: {porcentagemRJ.ToString("0")}% - Valor {rj.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Porcentagem de faturamento mensal de MG foi de: {porcentagemMG.ToString("0")}% - Valor {mg.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Porcentagem de faturamento mensal de ES foi de: {porcentagemES.ToString("0")}% - Valor {es.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Porcentagem de faturamento mensal de Outros foi de: {porcentagemOTS.ToString("0")}% - Valor {outros.ToString("C", CultureInfo.CurrentCulture)}");
// ===============================================
/*
5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;

*/
// Console.Write("Digite uma palavra: ");
// string palavraEntrada = Console.ReadLine();
// Console.WriteLine(new string((new Stack<char>(palavraEntrada)).ToArray()));




