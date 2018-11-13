using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CheeseMVC.Models
{
    public class CheeseData
    {
        private static List<Cheeese> cheeses = new List<Cheeese>();

        public static List<Cheeese> GetAll()
        {
            return cheeses;
        }

        public static void Add(Cheeese newCheese)
        {
            cheeses.Add(newCheese);
        }

        public static void Remove(int id)
        {
            Cheeese cheeseToRemove = GetById(id);
            cheeses.Remove(cheeseToRemove);
        }

        public static Cheeese GetById(int id)
        {
            return cheeses.Single(x => x.CheeseId == id);
        }

      
    }
}
