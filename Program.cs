using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Quantidade de elementos do vetor: ");
        int tamanhoArray = int.Parse(Console.ReadLine());
        int[] vetor = new int[tamanhoArray];
        for (int i = 0; i < tamanhoArray; i++)
        {
            Console.Write($"Informe o {i + 1}º elemento do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(DiferencaEntreValores(vetor));
        Console.WriteLine($"O vetor está em ordem? {VetorEstaOrdenada(vetor)}");
    }
    public static String DiferencaEntreValores(int[] vetor)
     { 
         int contador = 0;
         Console.WriteLine("\nDiferença entre Valores:");
         foreach (var numero in vetor)
         {
             Console.WriteLine($"Posição {contador} => Value: {numero}");
             contador += 1;
         }
         Console.WriteLine($"\nInforme uma posicao do vetor de 0 à {vetor.Length - 1}");
         int posicao1 = int.Parse(Console.ReadLine());
         Console.WriteLine($"Informe outra posicao do vetor de 0 à {vetor.Length - 1}");
         int posicao2 = int.Parse(Console.ReadLine());
         int diferenca = Math.Abs(vetor[posicao1] - vetor[posicao2]);
         return "Diferença entre o valores é: " + diferenca;
     }
    public static Boolean VetorEstaOrdenada(int[] vetor)
     {
         for (int i = 1; i < vetor.Length; i++)
         {
             if (vetor[i] < vetor[i - 1])
             {
                 return false;
             }
         }
         return true;
    }
 }
