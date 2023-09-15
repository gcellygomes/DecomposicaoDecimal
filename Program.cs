int numeroDigitado, centenas, dezenas, unidades;

Console.Write("Digite um número...");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O número digitado e {numeroDigitado}");

centenas = numeroDigitado / 100;
dezenas = (numeroDigitado % 100) / 10;
unidades = (numeroDigitado % 100) % 10;

Console.WriteLine($"{unidades} unidades(s)");
Console.WriteLine($"{dezenas} dezenas(s)");
Console.WriteLine($"{centenas} centenas(s)");