using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5CompositePattern
{
    class Program
    {
        static IComponent componentA;
        static IComponent componentB;

        static void Main(string[] args)
        {
            // simple component with just a leaf
            componentA = new Leaf();
            // create a composite component with multiple leaves
            var composite = new CompositeComponent();
            composite.AddComponent(new Leaf());
            composite.AddComponent(new SecondTypeOfLeaf());
            composite.AddComponent(new AThirdLeafType());
            componentB = composite;

            // run something on both components
            componentA.Something();
            componentB.Something();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
