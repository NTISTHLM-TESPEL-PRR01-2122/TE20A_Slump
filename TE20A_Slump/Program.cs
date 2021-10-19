using System;

Random generator = new Random();

int woodInForest = 1000;

int howMuchWood = generator.Next(100);

Console.WriteLine(howMuchWood);

woodInForest -= howMuchWood;

if (howMuchWood < 50)
{
  Console.WriteLine("Not enough wood!");
}
else
{
  Console.WriteLine("A whole lotta wood!");
}

Console.ReadLine();
