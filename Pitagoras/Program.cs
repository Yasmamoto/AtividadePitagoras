using System;
class Pitagoras
{   static double CalcularPitagoras(double catet1, double catet2)
    {
        catet1 = Math.Pow(catet1, 2);
        catet2 = Math.Pow(catet2, 2);

        double hipotenusa = Math.Sqrt(catet1 + catet2);

        return hipotenusa;
    }
    static void menuzinho()
    {
        Console.WriteLine(" ----------------------");
        Console.WriteLine("|                      |");
        Console.WriteLine("| TEOREMA DE PITAGORAS |");
        Console.WriteLine("|                      |");
        Console.WriteLine(" ----------------------");
    }
    static void Main(string[] args)
    {
        menuzinho();
        Console.Write("Digite o primeiro cateto: ");
        double catet1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo cateto: ");
        double catet2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nO resultado do teorema de pitagoras deu {CalcularPitagoras(catet1, catet2).ToString("0.00")}");

        Console.ReadKey();
    }
}