using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Models
{
    public class Cheeese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CheeseId { get; set; }
        private static int nextId = 1;

        public Cheeese(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Cheeese() 
        {
            CheeseId = nextId;
            nextId++;
        }
    }
}
