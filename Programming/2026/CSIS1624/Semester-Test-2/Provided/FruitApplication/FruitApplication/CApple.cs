using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApplication
{
    public class CApple: CFruit
    {
        private bool IsOrganic { get; set; }

        public CApple(string picture, string fruitcode, double _weight, bool isorganic) :base(picture, fruitcode, _weight)
        {
            IsOrganic = isorganic;
        }
        public override string Details()
        {
            return $"PictureFile: {Pictures}\n" +
                $"FruitCode: {_fruitcode}\n" +
                $"Weight: {_Weight}\n" +
            $"IsOrganic: {(IsOrganic ? "Yes" : "No")}";
        }
        public override string FileDetails()
        {
            return $"Apple;{_fruitcode};{_Weight};{(IsOrganic ? "Yes" : "No")}";
        }
    }
}
