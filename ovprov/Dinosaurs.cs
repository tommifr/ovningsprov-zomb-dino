using System;
namespace ovprov;

    public class Dinosaurs: Attacker
{   
    Random generator = new Random();  //random generator
 
     public int intelligence = 0;
    public int strength = 0;
    public int tenacity = 0;

public void D()//ger dem ett random värde
{

    intelligence += generator.Next(10);
    strength += generator.Next(8);
    tenacity += generator.Next(5);

    Console.WriteLine("the stats for your Dinosaur is"+intelligence+"intelligence"+ strength+"strength"+tenacity+"tenacity");

    }

}