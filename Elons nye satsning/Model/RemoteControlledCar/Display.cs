using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elons_nye_satsning.Model.RemoteControlledCar
{
    internal class Display
    {
        private ushort _metersDriven;
        private Battery _battery = new Battery();

        public ushort MetersDriven
        {
            get { return _metersDriven; }
            set { _metersDriven = value; }
        }

        public Battery Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }
    }
}
