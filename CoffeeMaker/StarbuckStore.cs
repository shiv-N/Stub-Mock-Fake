using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker
{
    public class StarbuckStore
    {
        private readonly IMakeACoffee service;

        public StarbuckStore(IMakeACoffee service)
        {
            this.service = service;
        }

        public string OrderCoffee(int suggerPerSpone, int CoffeeCount)
        {
            if (service.CheckIngridentAvalability())
            {
                return service.CoffeeMaking(suggerPerSpone, CoffeeCount);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }       
        }
    }
}
