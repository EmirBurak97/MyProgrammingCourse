using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Sınıflar_
{
    class Customer
    {
        public int Id { get; set; }

        private string _name;
        public string Name { 
            get 
            {
                return "Ms. " + _name;
            } 
            set 
            {
                _name = value;
            } 
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
