using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Prototype.Car
{
    internal abstract class Vehicle
    {
        internal string VehicleType { get; set; }
        internal string Brand { get; set; }
        internal string Model { get; set; }

        internal ExtraInformation MoreInfo = new ExtraInformation();

        internal abstract void ShowDetails();
        internal abstract Vehicle ShallowCopy();
        internal abstract Vehicle DeepCopy();
    }
}
