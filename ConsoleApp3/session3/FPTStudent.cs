using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2203E.session3
{
    public class FPTStudent : AbstractStudent, IHuman, IStudent
    {
        public FPTStudent()
        {

        }
        public override void Learn()
        {


        }



        void IHuman.eat()
        {
           
        }

        void IStudent.PlayGame()
        {
            
        }
    }
}
