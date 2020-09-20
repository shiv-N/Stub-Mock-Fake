using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    public class Starbucks : IMakeACoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }

        string IMakeACoffee.CoffeeMaking(int suggerPerSpone, int CoffeePack)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Stub class of class Starbucks.
    /// </summary>
    public class StubStarbucks : IMakeACoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }

        public string CoffeeMaking(int suggerPerSpone, int CoffeePack)
        {
            return "Your Order is received.";
        }
    }
}
