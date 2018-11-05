using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CompositePattern
{
    public class AThirdLeafType : IComponent
    {
        public void Something()
        {
            Console.WriteLine("Leaf 3 - This is a maple leaf");
        }
    }
}
