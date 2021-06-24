using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedApp.Models
{
    public class MajorInfraction : Infraction
    {
        private static int _minSpeedLimit = 81;

        private static int _maxSpeedLimit = 500;

        private static readonly int _fineCode = 2;
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
            if (speed >= MinimumSpeedLimit)
            {
                return _fineCode;
            }

          return -1;
        }

    }
}

