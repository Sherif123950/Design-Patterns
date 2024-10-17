using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Main_Components
{
    internal abstract class Beverage
    {
        public virtual string Description { get; set; }
        public virtual decimal Cost { get; set; }

        public override string ToString()
        {
            return $"Description : {Description}\n" +
                $"Cost : {Cost}";
        }
    }
}
