using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class War3
    {
        public War3(string race, string hero, string army, string resource)
        {
            this.Race = race;
            this.Hero = hero;
            this.Army = army;
            this.Resource = resource;
        }

        public string Race { get; set; }
        public string Hero { get; set; }
        public string Army { get; set; }
        public string Resource { get; set; }

        public void Show()
        {
            Console.WriteLine("当前种族为 {0}", this.Race);
            Console.WriteLine("当前英雄状况为 {0}", this.Hero);
            Console.WriteLine("当前兵力状况为 {0}", this.Army);
            Console.WriteLine("当前资源状况为 {0}", this.Resource);
        }
    }
}
