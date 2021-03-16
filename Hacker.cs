using System;

namespace HeistTwo
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public Hacker(string name)
        {
            Name = name;

        }


        public void PerformSkill(Bank other)
        {
            // Console.WriteLine($"{Name}is hacking the alarm system. Decreased security {SkillLevel} points");
        }
    }

}