using System;
namespace ovprov;


public class Attacker
    {
     Random generator = new Random();
    public int intelligence = 0;
    public int strength = 0;
    public int tenacity = 0;



public int ArmWrestle()
{

    int result = Random.Shared.Next(0,10)+ strength; // adderar styrka och ett random nummer och om de blir över 20 så ger den tillbaka till bara 20

      if (result > 20)
    {
      return 20;
    }
    else
    {
      return result;
    }
}


public int Chess()
    {
            int result = Random.Shared.Next(0,10)+ intelligence; //adderar intelligence och random nummer

      if (result > 20)
    {
      return 20;
    }
    else
    {
      return result;
    }


}

public int Wrestling()
{
    int result = Random.Shared.Next(0,10)+ tenacity+strength; //adderar styrka tenacity och ranodom nummer

      if (result > 20)
    {
      return 20;
    }
    else
    {
      return result;
    }
}

}
