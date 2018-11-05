using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CompositePattern
{
    class Leaf : IComponent
    {
        public void Something()
        {
            Console.WriteLine("Leaf 1 - This is a Elm leaf");
        }
    }
}
