using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApplication
{
    class COrange:CFruit
    {
        private bool IsSeedless { get; set; }

        public COrange(string picture, string fruitcode, double _weight, bool iseedless) : base(picture, fruitcode, _weight)
        {
            IsSeedless = iseedless;
        }
        public override string Details()
        {
            return $"PictureFile: {Pictures}\n" +
                $"FruitCode: {_fruitcode}\n" +
                $"Weight: {_Weight}\n" +
            $"IsSeedless: {(IsSeedless ? "Yes" : "No")}";
        }
        public override string FileDetails()
        {
            return $"Orange;{_fruitcode};{_Weight};{(IsSeedless ? "Yes" : "No")}";
        }
    }
}
