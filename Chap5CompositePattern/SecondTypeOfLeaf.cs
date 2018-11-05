using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CompositePattern
{
    public class SecondTypeOfLeaf : IComponent
    {
        public void Something()
        {
            Console.WriteLine("Leaf 2 - This is a Birch leaf");
        }
    }
}
