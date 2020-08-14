using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    public class Coach
    {
        public int Id { get; set; }

        public string  FullName { get; set; }
        
        public string  Email { get; set; }
        
        public string  MobileNumber { get; set; }
        
        public enum Specialization 
        { 
            Dance,
            Yoga, 
            Aerobics,
            PowerLifting
        }
        
        public Specialization Specializations { get; set; }
    }
}
