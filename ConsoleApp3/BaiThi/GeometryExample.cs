using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2203E.BaiThi
{
    public class GeometryExample
    {
        public class Cylinder
        {
            public Cylinder() { }

            public float Radius { get; set; }

            public float Height { get; set; }

            public float BaseArea { get; set; }

            public float LateralArea { get; set; }

            public float TotalArea { get; set; }

            public float Volume { get; set; }
            public float Process()
            {
                BaseArea = (float)(Radius * Radius * Math.PI);

                LateralArea = (float)(2 * Math.PI * Radius * Height);

                TotalArea = (float)(2 * Math.PI * Radius * (Height + Radius));

                Volume = (float)(Math.PI * Radius * Radius * Height);
                return 0;
            }

            public void Result()
            {
                Console.WriteLine("Enter cylinder");
                Console.WriteLine("Radius : " + Radius);
                Console.WriteLine("Height : " + Height +"\n");



                Console.WriteLine("Cylinder Print");
                Console.WriteLine("Radius : " + Radius + "Height : " + Height);
                Console.WriteLine("BaseArea: " + BaseArea + "|" + "LateralArea: " + LateralArea + "|" + "TotalArea: " + TotalArea + "|" + "Volume: "+ Volume);

            }
        }
    }
}

