using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19362090_HW04.Models
{
    public class Plastic : Recycle
    {
        public string PlasticType { get; set; }
        public string Color { get; set; }
        public int RecyclingRating{ get; set; }
        public Plastic(int recycleID, string fullName, double weight, int noOfBags, string plasticType, string color, int recycleRating) :base(recycleID, fullName,weight, noOfBags)
        {
            PlasticType = plasticType;
            Color = color;
            RecyclingRating = recycleRating;
        }

        public Plastic()
        {

        }
        public override double CalculatePullCost()
        {
            return 25;
        }
    }
}