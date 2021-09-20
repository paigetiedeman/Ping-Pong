using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Input a number:");
    string inputNumber = Console.ReadLine();
    int number =  int.Parse(inputNumber);
    for(int i=1; i<=number; i++)
    {
      if (i % 5 == 0 && i % 3 == 0) 
        Console.WriteLine("Ping-Pong!");
      else if (i % 3 == 0)
        Console.WriteLine("Ping");
      else if (i % 5 == 0)
        Console.WriteLine("Pong");
      else 
        Console.WriteLine(i);
      
    }
  }
}