using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elons_nye_satsning.Model.RemoteControlledCar
{
    internal class Battery
    {
        private byte _charge;


        public byte Charge
        { 
            get { return _charge; }
            set {  _charge = value; } 
        }

        public void recharging()
        {
            Charge = 100;
        }
    }
}
