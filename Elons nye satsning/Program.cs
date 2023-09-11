using Elons_nye_satsning.Class;
using Elons_nye_satsning.Model.RemoteControlledCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elons_nye_satsning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RCCarController controller = new RCCarController();
            controller.start();
        }
    }
}
