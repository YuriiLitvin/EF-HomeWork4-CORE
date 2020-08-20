using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    public class Coach : BaseEntity
    {
        //public new int Id { get; set; }

        public string  FullName { get; set; }
        
        public string  Email { get; set; }
        
        public string  MobileNumber { get; set; }
        
        public TypeOfTraining Trainings { get; set; }
        
        public Workout Workout { get; set; }

    }
}
