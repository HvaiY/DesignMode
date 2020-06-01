using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class E : AbstractCharactor
    {
        public E()
        {
            Console.WriteLine("E在这里被实例化");
        }

        public override string GetWord()
        {
            return "e";
        }
    }
}
