using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld.AbstractClass
{
    public abstract class IHuman:IWorld
    {
        public string Think()
        {
            return "";
        }

        public string Behavior()
        {
            return "";
        }
    }
}
