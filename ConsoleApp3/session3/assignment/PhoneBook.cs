using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2203E.session3.assignment
{
    internal class PhoneBook : Phone
    {
        public List<PhoneNumber> PhoneList;
        public PhoneBook() {
            PhoneList = new List<PhoneNumber>();
        }  
        public override void InsertPhone(String name, String phone)
        {
            PhoneNumber p = new PhoneNumber();
            foreach(PhoneNumber pl in PhoneList) {
                if (pl.Name.Equals(p.Name))
                {
                    
                }
            }
            
        }

        public override void RemovePhone(String name)
        {
            
        }

        public override void SearchPhone(String name)
        {
            
        }

        public override void SortPhone()
        {
           
        }

        public override void UpdatePhone(String name, String newPhone)
        {
            
        }
    }
}
