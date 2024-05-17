using System;
using ovprov;

List<Dinosaurs> dinosaurs = new List<Dinosaurs>();
List<Zombies> zombies = new List<Zombies>();

int number =0;

bool success = false;

while (success == false) // läser vilken mängden som ska skapas och om input inte är en siffra körs den om
{
  Console.Write("type in the amount of zombies and dinosaurs you want in each team: ");
  string input=Console.ReadLine();

  success = int.TryParse(input, out number);

   if (success && number < 1)
    {
        success = false;
    }

}
for (int i = 0; i < number; i++)//skapar mängden som skrevs in
{
    Zombies zomb = new Zombies();
    Dinosaurs dino = new Dinosaurs();
    
    zombies.Add(zomb);
    dinosaurs.Add(dino);
    
}

Console.WriteLine("spawned: " + zombies.Count() +" Zombies");
Console.WriteLine("spawned: " + dinosaurs.Count() +" Dinosaurs");

Console.ReadLine();

