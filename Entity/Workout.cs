using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    public class Workout : BaseEntity
    {
        //public new int Id { get; set; }
        
        public TypeOfTraining TypeOfTraining { get; set; }

        public int CoachId { get; set; }
        public int GymId { get; set; }

        public int StartTime { get; set; }
        public int FinishTime { get; set; }
    }

    
}
