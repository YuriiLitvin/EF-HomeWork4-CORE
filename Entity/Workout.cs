using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    public class Workout : BaseEntity
    {
        //public new int Id { get; set; }
        
        public TypeOfTraining Trainings { get; set; }

        public Coach Coach { get; set; }
        public Gym Gym { get; set; }

        public int StartTime { get; set; }
        public int FinishTime { get; set; }
    }

    
}
