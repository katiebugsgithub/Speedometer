using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedApp.Models
{
    public class Infraction
    {
        public virtual int MaxSpeedLimit { get; set; }

        public virtual int FineCode { get; }

        public virtual int MinimumSpeedLimit { get; set; }
        public virtual int GetFineCode(int speed)
        {
            return -1;
        }
        public void BirthdayBreak(bool isBirthday)
        {
            if(isBirthday)
            {
                MaxSpeedLimit += 5;
                MinimumSpeedLimit += 5;
            }
        }
       

     
    }
}
