using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.session1
{
    internal class Human
    {
        public string name;
        public string emmail;
        public int age;
        public static int xyz;
        private int id;
        public Human()
        {

        }
        public Human( string s )
        {
            this.name = s;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get => name;
            set=> name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Email { get; set; }//PROPERTIES
        public void Run()
        {
            Console.WriteLine("Running....");
            this.name = "Do van Thang";
        }
        public void Run(string s)
        {
            Console.WriteLine("Running....sssss");
        }
        
        public static void ScreenShot()
        {

        }
        public virtual void Eat()
        {
            // hàm có thể ghi đè lại
        }
       


    }
}
