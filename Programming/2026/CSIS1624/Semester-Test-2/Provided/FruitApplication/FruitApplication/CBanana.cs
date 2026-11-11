using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApplication
{
    class CBanana: CFruit
    {
        private bool IsRipe
        {
            get { return IsRipe; }
            set { IsRipe = value; }
        }

        public CBanana(string picture, string fruitcode, double _weight, bool isRipe) : base(picture, fruitcode, _weight)
        {
            IsRipe = isRipe;
        }
        public override string Details()
        {
            return $"PictureFile: {Pictures}\n" +
                $"FruitCode: {_fruitcode}\n" +
                $"Weight: {_weight}\n" +
            $"IsRipe: {(IsRipe ? "Yes" : "No")}";
        }
        public override string FileDetails()
        {
            return $"Banana;{_fruitcode};{_weight}:{(IsRipe ? "Yes" : "No")}";
        }
    }
}

