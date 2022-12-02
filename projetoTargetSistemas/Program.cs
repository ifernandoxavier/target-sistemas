using projetoTargetSistemas.Models;
using Newtonsoft.Json;
using System.Globalization;
////===============================================
/*
1) Resposta: 91;

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
2) 

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
3) 

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
4) 

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
5) 

*/
// Console.Write("Digite uma palavra: ");
// string palavraEntrada = Console.ReadLine();
// Console.WriteLine(new string((new Stack<char>(palavraEntrada)).ToArray()));




