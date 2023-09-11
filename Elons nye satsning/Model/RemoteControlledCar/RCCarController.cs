using Elons_nye_satsning.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elons_nye_satsning.Model.RemoteControlledCar
{
    /// <summary>
    /// Class <c>RCCarController</c> controls how the car functions and when the screen should display what
    /// </summary>
    internal class RCCarController
    {
        RCCarGUI gui = new RCCarGUI();
        RCCar car = new RCCar();
        /// <summary>
        /// start controls what happens when the car is driving or needs to be recharged
        /// </summary>
        public void start()
        {
            while(car.Battery.Charge > 0)
            {
                gui.printDisplay(car.Battery.Charge, car.Display.MetersDriven);
               
                if(car.Display.MetersDriven%20 == 0 && car.Display.MetersDriven != 0) 
                {
                    car.Battery.Charge--;
                }
            }
            gui.recharge();
        }

        /// <summary>
        /// Setting the battery charge to 100 and how far the car has driven to 0 meters
        /// </summary>
        public void charging()
        {
            car.Battery.recharging();
            car.Display.MetersDriven = 0;
        }
    }
}
