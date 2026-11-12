using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApplication
{
    public abstract class CFruit
    {
        public string Pictures { get; set; }

        private string Fruitcode;

        private double Weight;
        public string _fruitcode
        {
            get { return Fruitcode; }
            set
            {
                if (value.StartsWith("F-"))
                {
                    Fruitcode = value;
                }
                else
                {
                    throw new ArgumentException("Fruit code should start with F-");
                }
            }

        }
        public double _Weight
        {
            get { return Weight; }
            set
            {
                if (value >= 1 && value <= 50)
                {
                    Weight = value;
                }
                else
                {
                    throw new ArgumentException("Weight must be between 1 and 50 kg.");
                }
            }

        }
        public CFruit(string picture, string fruitcode, double _weight)
        {
            Pictures = picture;
            _fruitcode = fruitcode;
            _Weight = _weight;
        }
        public abstract string Details();
        public virtual string FileDetails()
        {
            return $"{_fruitcode};{_Weight}";
        }
    }
}
