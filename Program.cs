using System;
using System.Collections.Generic;

namespace HeistTwo
{
    class Program
    {
        static void Main(string[] args)

        {
            Bank AmeriTheft = new Bank();
            AmeriTheft.AlarmScore = 200;
            AmeriTheft.CashOnHand = 200000;
            AmeriTheft.SecurityGuardScore = 500;
            AmeriTheft.VaultScore = 100;

            Muscle george = new Muscle();
            george.Name = "George";
            george.PercentageCut = 25;
            george.SkillLevel = 25;

            Hacker sandra = new Hacker();
            sandra.Name = "Sandra";
            sandra.SkillLevel = 50;
            sandra.PercentageCut = 25;

            Hacker luke = new Hacker();
            luke.Name = "Luke";
            luke.SkillLevel = 5;
            luke.PercentageCut = 5;

            LockSpecialist heidi = new LockSpecialist();
            heidi.Name = "Hedi";
            heidi.SkillLevel = 30;
            heidi.PercentageCut = 15;

            List<IRobber> rolodex = new List<IRobber>()
            {
                george,sandra,heidi, luke
            };
            foreach (IRobber robber in rolodex)
                Console.WriteLine($"  {robber.Name} skill level:{robber.SkillLevel}");

            // foreach (Hacker hacker in rolodex)
            //     Console.WriteLine($"  {hacker.Name} {hacker.SkillLevel}");

            Console.WriteLine("Recommend a fellow felon here:");
            string newFelon = Console.ReadLine();
            // IRobber.Add(newFelon);
            Hacker newHacker = new Hacker(newFelon);
        }

    }
}
