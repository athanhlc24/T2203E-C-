using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2203E.session4
{
    public delegate void StringToVoid(string s);

    public class DemoDelegate
    {
        public DemoDelegate() 
        {

        }
        public void ShowInfo(string s)
        {
            Console.WriteLine("HELLO "+s);
        }
        public static void SayHello(string str)
        {
            Console.WriteLine("say: "+str);
        }
    }
}
