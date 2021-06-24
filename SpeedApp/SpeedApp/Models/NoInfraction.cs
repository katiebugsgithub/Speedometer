using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedApp.Models
{
    public class NoInfraction : Infraction
    {
        private static int _minSpeedLimit = 0;

        private static int _maxSpeedLimit = 60;

        private static readonly int _fineCode = 0;
        public override int MaxSpeedLimit
        {
            get
            {
                return _maxSpeedLimit;
            }
        }
        public override int MinimumSpeedLimit
        {
            get
            {
                return _minSpeedLimit;
            }
        }

        public override int FineCode
        {
            get
            {
                return _fineCode;
            }
        }       

        public override int GetFineCode(int speed)
        {
            if (speed <= MaxSpeedLimit)
            {
                return FineCode;
            }
            else return -1;
        }
    }
}
