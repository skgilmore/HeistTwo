using System;
using System.Collections.Generic;

namespace HeistTwo
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }

        // List<IRobber> rolodex = new List<IRobber>
        void PerformSkill(Bank other)
        {
            //     foreach (IRobber robber in rolodex)
            //         Console.WriteLine($"  {robber.Name} (${robber.SkillLevel})");
        }


    }
}

