using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedApp.Models
{
    public class SpeedService
    {
        public int checkforFines(int speed, bool isBirthday)
        {     
           
            NoInfraction no = new NoInfraction();
            no.BirthdayBreak(isBirthday);
            int code = no.GetFineCode(speed);
            if(code == -1)
            {
                MinorInfraction minor = new MinorInfraction();
                minor.BirthdayBreak(isBirthday);
                code = minor.GetFineCode(speed);
            }
            if(code == -1)
            {
                MajorInfraction major = new MajorInfraction();
                major.BirthdayBreak(isBirthday);
                code = major.GetFineCode(speed);
            }

            return code;
        }

    }
}
