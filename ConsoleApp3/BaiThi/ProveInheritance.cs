using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2203E.BaiThi
{
    public class ProveInheritance
    {
        public ProveInheritance() { }
        public int Weight { get; set; }
        public string Name { get; set; }

        public void Show()
        {

        }
        public void  SetMe( int Weight, string Name)
        {
            Console.WriteLine("Name: " + Name + " " + "Weight: " + Weight);
        }
    }
}
