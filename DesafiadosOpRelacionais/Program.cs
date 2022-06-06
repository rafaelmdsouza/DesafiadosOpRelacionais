double nota;
bool notaApr, notaRecu;

Console.WriteLine("Digite sua nota:");

nota = double.Parse(Console.ReadLine());
notaApr = nota >= 7;
notaRecu = nota > 5 && nota < 7;

if (notaApr)
    Console.WriteLine($"Você foi aprovado com a nota de {nota}");

else if (notaRecu)
    Console.WriteLine($"Você tirou {nota} e está de recuperação");

else
    Console.WriteLine($"Você foi reprovado.");

Console.WriteLine("------------------------------------------------------");

// OPERADOR TERNÁRIO

Console.WriteLine("OPERADOR TERNÁRIO");
Console.WriteLine();
Console.WriteLine("Digite sua nota:");
double TNota = double.Parse(Console.ReadLine());

var TNotaApr = TNota >= 7 ? "Você foi aprovado." : ((TNota >=5 && TNota<7 ? "Você está de recuperação." : "Você foi reprovado."));
Console.WriteLine(TNotaApr); 
