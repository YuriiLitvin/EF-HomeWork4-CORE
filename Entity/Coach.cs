using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    class Coach
    {
        public int Id { get; set; }

        public string  FirstName { get; set; }
        
        public string  LastName { get; set; }
        
        public string  Email { get; set; }
        
        public string  MobileNumber { get; set; }
        
        //public List<string> Specialization { get; set; }

        public Gym Gym { get; set; }



    }
}
