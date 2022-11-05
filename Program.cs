int numeroInicial = 0;
System.Console.Write(" Numeros pares entre 0 - ");
int numeroLimite = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Magenta;
while (numeroInicial <= numeroLimite)

{
  System.Console.Write($" {numeroInicial} " );
  numeroInicial += 2;

}

Console.ResetColor();

System.Console.WriteLine();

