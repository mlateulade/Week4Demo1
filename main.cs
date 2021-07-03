using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
  //Arrays will hold collection of similar data


  //Array declaration
  int[] salary = {70000, 35000, 45000};

  //Array elements start at position 0
  Console.WriteLine(salary[0]);
  Console.WriteLine(salary[1]);
  Console.WriteLine(salary[2]);

  //Overwrite value for location 1 in salary array
  salary[1] = 86000;

  Console.WriteLine(salary[0]);
  Console.WriteLine(salary[1]);
  Console.WriteLine(salary[2]);

  int len = salary.Length;
  Console.WriteLine("Length = " + len);

  Console.WriteLine("Using for a loop");

  for(int pos=0; pos <= len-1; pos++)
  {
    Console.WriteLine(salary[pos]);
  }

  Console.WriteLine("Sort");
  Array.Sort(salary);
   for(int pos=0; pos <= len-1; pos++)
  {
    Console.WriteLine(salary[pos]);
  }

  Console.WriteLine("Reverse");
  Array.Reverse(salary);
   for(int pos=0; pos <= len-1; pos++)
  {
    Console.WriteLine(salary[pos]);
  }

  int min = salary.Min();
  Console.WriteLine("Min value = " + min);

  int max = salary.Max();
  Console.WriteLine("Max value = " + max);

  int sum = salary.Sum();
  Console.WriteLine("Sum = " + sum);

  }
}