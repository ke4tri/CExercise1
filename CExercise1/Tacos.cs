using System;
using System.Collections.Generic;
using System.Text;

namespace CExercise1
{
    class Tacos
    {
        public string Type { get; set; }
        public string Meat { get; set; }

        public Tacos(string type, string meat)
        {
            Type = type;
            Meat = meat;
        }
    }
}
