using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    public class Coach : IdClass
    {
        public new int Id { get; set; }

        public string  FullName { get; set; }
        
        public string  Email { get; set; }
        
        public string  MobileNumber { get; set; }
        
        public enum Specialization 
        { 
            Dance,
            Yoga, 
            Fitness,
            PowerLifting
        }
        
        public Specialization Specializations { get; set; }
    }
}
