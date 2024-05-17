using System;
namespace ovprov;

public class Zombies :Attacker

{
    Random generator = new Random(); //random generator
    public int intelligence = 0;
    public int strength = 0;
    public int tenacity = 0;

public void Z()// ger dem ett random värde
{

    intelligence += generator.Next(5);
    strength += generator.Next(8);
    tenacity += generator.Next(10);

    Console.WriteLine("the stats for your zombie is"+intelligence+"intelligence"+ strength+"strength"+tenacity+"tenacity");

    }

}