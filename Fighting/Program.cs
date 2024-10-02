

﻿int heroHp = 100;
int villainHp = 100;

string heroName = "AYRTON SENNA";
string villainName = "MICHAEL SCHUMACHER";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("\n----- ===== NEW ROUND ===== -----");
  Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}\n");

  int heroDamage = Random.Shared.Next(20);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== THE FIGHT IS OVER ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("DRAW");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} WON!");
}
else
{
  Console.WriteLine($"{heroName} WON!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");


Console.ReadLine();