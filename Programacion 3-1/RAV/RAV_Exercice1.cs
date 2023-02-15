using System;

namespace Ejercicios
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      /* EJERCICIO 2
      Realizar un programa que ingrese un vector de n elementos e imprimir 
      el menor y un mensaje si se repite dentro del vector dicho numero. */
      Console.WriteLine("N numbers: ");
      int n = int.Parse(Console.ReadLine());
      int[] numeros = new int[n];
      
      Console.WriteLine("Input numbers in the number array: ");
      
      for(int i = 0; i < n; i++){
          Console.Write("Elemento " + i + ": ");
          numeros[i] = int.Parse(Console.ReadLine());
          
      }
      
      int lower = numeros[0];
      bool itRepeats = false;
      
      for(int i = 1; i < n; i++){
          if (numeros[i] < lower){
              lower = numeros[i];
          } else if(numeros[i] == lower){
              itRepeats = true;
          }
          
      }
      
      Console.WriteLine("El menor es: " + lower);
      if(itRepeats){
          Console.WriteLine("Ese numeros se repite");
      }else{
          Console.WriteLine("Ese numero no se repite");
      }
      
    }
  }
}