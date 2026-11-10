using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DisplayedInfo
    {
        public string Name {get; set;}
        public string Age { get; private set; }
        public string ChosenAnimal { get; set; }
        public DisplayedInfo(string name, string age, string chosenAnimal)
        {
            Name = name;
            Age = age;
            ChosenAnimal = chosenAnimal;
        }
        public virtual string Registration()
        {
            return $"\n===================================================" +
                $"| Name: {Name}\n" +
                $"| Age: {Age}" +
                $"| PetFish: {ChosenAnimal}\n" +
                $"\n|   Thank you for choosing to purchase and take care of our cute little baby fish.\n" +
                $"| Be Blessed!\n" +
                $"| ............\n" +
                $"=========================================================";
        }
    }
}
