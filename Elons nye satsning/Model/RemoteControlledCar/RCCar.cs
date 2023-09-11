using Elons_nye_satsning.Model.RemoteControlledCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elons_nye_satsning.Class
{
    internal class RCCar
    {
        #region Properties

        private string _colour;
        private Display _display = new Display();
        private Battery _battery = new Battery();

        #endregion



        #region PublicMethods

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public Display Display
        {
            get { return _display; }
            set { _display = value; }
        }
        public Battery Battery
        { 
            get { return _battery; }
            set { _battery = value; }
        }
        
        #endregion
    }
}
