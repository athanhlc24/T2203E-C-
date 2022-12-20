using ConsoleApp3.session1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2203E.session1
{
    internal class Student: Human
    {
        private string[] telephone = new string[3];
        public Student()
        {

        }
        public Student(string s, int a): base(s)
        {
            this.age= a;
        }
        public string this[int index]// indexer
        {
            get => telephone[index];
            set => telephone[index]= value;
        }
        public void Study()
        {
            base.Run();// chạy hàm bên human cha chạy vào con
            this.Run();// chạy hàm bên dưới 
        }
        public new void Run()
        {

        }
        public override void Eat()// ghi đè lại 
        {
            base.Eat();

        }
    }
}
