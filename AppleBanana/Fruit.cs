using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBanana
{
    public class Fruit
    {
        public string Name { get; set; }
        public float Price { get; set; }


        public string SayName()
        {
            return Name;
        }
    }
}
