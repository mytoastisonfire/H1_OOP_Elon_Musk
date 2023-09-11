using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elons_nye_satsning.Model.RemoteControlledCar
{
    internal class RCCarGUI
    {
        //Battery battery = new Battery();
        //Display display = new Display();

        public void printDisplay(int battery, int metersDriven)
        {
            Console.WriteLine("The battery is at " + battery + "% charge.");
            Console.WriteLine("And it has driven " + metersDriven + "meters.");
        }
        public void recharge()
        {
            Console.WriteLine("The car's battery is completely empty. It cannot continue driving without being charged.");
        }
    }
}
