using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Snake : Reptile
    {
        public string CanBite { get; set; }


        public override string Move()
        {
            return String.Format("I {0}", CanRun);
        }
        public override string Talk()
        {
            return String.Format("I can {0}", CanBite);
        }
     

    }
    }
