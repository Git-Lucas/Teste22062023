//int numeroInformado;

//Console.WriteLine("Informe um número para verificação se pertence à sequência de Fibonacci: ");
//numeroInformado = Convert.ToInt32(Console.ReadLine());

//var numerosCalculadosSequenciaFibonacci = new List<int>
//{
//    0,
//    1
//};

//var ultimoNumero = numerosCalculadosSequenciaFibonacci.ElementAt(
//    numerosCalculadosSequenciaFibonacci.Count - 1
//    );
//var penultimoNumero = numerosCalculadosSequenciaFibonacci.ElementAt(
//    numerosCalculadosSequenciaFibonacci.Count - 2
//    );

//while (numeroInformado > ultimoNumero)
//{
//    numerosCalculadosSequenciaFibonacci.Add(ultimoNumero + penultimoNumero);

//    ultimoNumero = numerosCalculadosSequenciaFibonacci.ElementAt(
//    numerosCalculadosSequenciaFibonacci.Count - 1
//    );
//    penultimoNumero = numerosCalculadosSequenciaFibonacci.ElementAt(
//        numerosCalculadosSequenciaFibonacci.Count - 2
//    );
//}

//if (numerosCalculadosSequenciaFibonacci.Contains(numeroInformado))
//{
//    Console.WriteLine("O número pertence à sequência de Fibonacci!");
//}
//else
//{
//    Console.WriteLine("O número não pertence à sequência de Fibonacci!");
//}

//double[] faturamento = new double[20]
//{
//    800, 0, 300, 1000, 700,
//    900, 600.50, 0, 1000, 700,
//    500, 250.45, 900, 750, 600,
//    0, 600.50, 300, 1100, 700
//};

//var faturamentoSemValoresZerados = faturamento.Where(x => x != 0).ToArray();

//Array.Sort(faturamentoSemValoresZerados);
//Console.WriteLine($"Menor valor de faturamento em um dia do ano: {faturamentoSemValoresZerados[0]}");
//Console.WriteLine($"Maior valor de faturamento em um dia do ano: {faturamentoSemValoresZerados[faturamentoSemValoresZerados.Length - 1]}");

//var media = faturamentoSemValoresZerados.Average();
//var faturamentoSuperiorAMedia = faturamentoSemValoresZerados.Where(
//    x => x > media).ToArray();

//Console.WriteLine($"Número de dias no ano em que o valor de faturamento diário foi superior à média anual: {faturamentoSuperiorAMedia.Length}");

//List<FaturamentoPorEstado> faturamentosPorEstado = new()
//{
//    new() { Estado = "SP", Faturamento = 67836.43},
//    new() { Estado = "RJ", Faturamento = 36678.66},
//    new() { Estado = "MG", Faturamento = 29229.88},
//    new() { Estado = "ES", Faturamento = 27165.48},
//    new() { Estado = "Outros", Faturamento = 19849.53}
//};

//double valorGlobal = faturamentosPorEstado.Sum(x => x.Faturamento);

//foreach(var item in faturamentosPorEstado)
//{
//    Console.WriteLine($"{item.Estado}: {item.Porcentagem(valorGlobal).ToString("F")}%");
//}

//public class FaturamentoPorEstado
//{
//    public string Estado { get; set; }
//    public double Faturamento { get; set; }

//    public double Porcentagem(double valorGlobal) => Faturamento * 100 / valorGlobal;
//}