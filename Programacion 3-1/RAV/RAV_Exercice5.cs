using System;

namespace Ejercicios
{
  public static class Program
  {
    public static void Main(string[] args)
    { 
      int[] numbers = new int[5];
      
      for(int i = 0; i < 5; i++){
          Console.WriteLine($"Ingrese el numero {i + 1}: ");
          numbers[i] = int.Parse(Console.ReadLine());
      }
      
      Array.Sort(numbers);
      Console.WriteLine($"El primer: {numbers[0]}");
      Console.WriteLine($"El ultimo: {numbers[4]}");
      Console.WriteLine($"El del medio: {numbers[2]}");
      
    }
  }
}