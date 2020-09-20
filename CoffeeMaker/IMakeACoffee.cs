using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    public interface IMakeACoffee
    {
        bool CheckIngridentAvalability();

        string CoffeeMaking(int suggerPerSpone, int CoffeePack);
    }
}
