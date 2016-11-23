using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Lizzard : Reptile
    {
        public string CanLoseTail { get; set; }

        public override string Move()
        {
            return String.Format("I can {0}", CanRun);
        }

        public override string Talk()
        {
            return String.Format("I can't talk but I can lose my {0}", CanLoseTail);
        }

    }
}