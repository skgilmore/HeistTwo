using System;

namespace HeistTwo
{
    public class Bank
    {
        public int CashOnHand { get; set; }

        public int AlarmScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public int VaultScore { get; set; }
        public bool IsSecure
        {
            get { return false; }
            set
            {
                if (CashOnHand != 0 || AlarmScore != 0 ||
          SecurityGuardScore != 0 || VaultScore != 0) IsSecure = true;
            }
        }
    }

}
