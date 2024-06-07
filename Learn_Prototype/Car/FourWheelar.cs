using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Prototype.Car
{
    internal class FourWheelar : Vehicle, ICloneable
    {
        internal override Vehicle ShallowCopy()
        {
            return this.MemberwiseClone() as Vehicle;
        }

        internal override Vehicle DeepCopy()
        {
            Vehicle vehicle = this.MemberwiseClone() as Vehicle;
            vehicle.MoreInfo = new ExtraInformation();
            vehicle.MoreInfo.Cost = this.MoreInfo.Cost;
            vehicle.MoreInfo.Ratings = this.MoreInfo.Ratings;
            return vehicle;
        }

        internal override void ShowDetails()
        {
            Console.WriteLine(string.Format("Vehicle Type: {0} \tBrand: {1} \tModel: {2} \tCost: {3} \tRatings: {4}", this.VehicleType, this.Brand, this.Model, this.MoreInfo.Cost, this.MoreInfo.Ratings));
        }

        public object Clone()
        {
            return DeepCopy();
        }
    }
}
