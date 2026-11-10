using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CFishType
    {
        private string Name { get; set; }
        private string Danger { get ; set; }
        private string HealthBenefits { get; set; }
        private string AverageLength { get; set; }
        public CFishType(string name, string danger, string health, string average)
        { 
            Name = name;
            Danger = danger;
            HealthBenefits = health;
            AverageLength = average;
        }

        public virtual string Describe()
        {
            return @"Name: Fish
                    Danger: Low
                    Health Benefits: Rich
                    Average Length: 0.5 m to 12 m (varies greatly by species)";
        }
    }
}
