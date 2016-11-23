using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public abstract class Animal
    {
        public int Age { get; set; }
   
        public int Weight { get; set; }
        

        public virtual string Move()
        {
            return String.Format("Jag kan");
        }

        public virtual string Talk()
        {
            return String.Format(" Jag kan ");
        }
    }
}