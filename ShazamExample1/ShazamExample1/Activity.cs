using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    enum ActivityType
    {
        Study,
        Meditation,
        Calm,
        Moderate,
        Strenuous,
        Driving,
        Chores,
        Sad,
        Hype,
        InMyFeelings,
        InMyShower
    }
    class Activity
    {
        public string ActivityName;
        public ActivityType thisActivityType;
    }
}
