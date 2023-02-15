using System;

namespace Ejercicios
{
  public static class Program
  {
    public static void Main(string[] args)
    { 
      /*
      ejercicio 5 
      ingrese los numeros 7, 5, 4, 3 y 9  y debe mostrarnos cual es el primer numero cual es el ultimo y 
      cual es el numero del medio */
      Console.WriteLine("Array's length: ");
      int arrayLength = int.Parse(Console.ReadLine());
      int[] arr1 = new int[arrayLength];
      int[] arr2 = new int[arrayLength];
      int[] sub = new int[arrayLength];
      
      for(int i = 0; i < arrayLength; i++){
              Console.Write($"Number at index {i} in the array 1: ");
              arr1[i] = int.Parse(Console.ReadLine());
      }
      for(int j = 0; j < arrayLength; j++){
              Console.Write($"Number at index {j} in the array 2: ");
              arr2[j] = int.Parse(Console.ReadLine());
      }    
     
      
      
      //RESTA DE LOS ARREGLOS
      for(int x = 0; x < arrayLength; x++){
          sub[x] = arr1[x] - arr2[x];
      }
      
      Console.WriteLine("La resta de los vectores: ");
      for(int y = 0; y < arrayLength; y++){
          Console.Write(sub[y] + ", ");
      }
    }
  }
}