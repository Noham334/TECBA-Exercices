using System;

namespace Ejercicios
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      /* EJERCICIO 1
      Realizar un programa que permita ingresar los nombres de 5
      operarios y sus sueldos respectivos. Mostrar el sueldo mayor 
      y el nombre del operario. */
      string[] employees = new string[5];
      int[] salary = new int[5];

      for (int i = 0; i < 5; i++) 
      {
        Console.WriteLine("Employee #" + i);
        Console.WriteLine("Name: ");
        employees[i] = Console.ReadLine();
        Console.WriteLine("Salary: ");
        salary[i] = int.Parse(Console.ReadLine());
      }

      int maxSalary = 0;
      for(int i = 0; i < 5; i++){
        if (salary[i] > salary[maxSalary]){
          maxSalary = i;
        }
      }

      Console.WriteLine("El mayor sueldo es: $" + salary[maxSalary] + " y su nombre es: " + employees[maxSalary]);


    }
  }
}