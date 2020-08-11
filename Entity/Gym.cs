using System;
using System.Collections.Generic;
using System.Text;

namespace EF_HomeWork_4_CORE.Entity
{
    class Gym
    {
        public string Title { get; set; }

        public int TrainingPeolpeCount { get; set; }

        public List<Coach> Coaches { get; set; }
    }
}
