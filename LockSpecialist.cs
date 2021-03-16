using System;

namespace HeistTwo
{
    public class LockSpecialist : IRobber
    {
        public LockSpecialist()
        {
        }

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
    }

}