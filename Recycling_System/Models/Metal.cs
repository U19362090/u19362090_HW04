using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19362090_HW04.Models
{
    public class Metal : Recycle
    {
        public string MetalType { get; set; }    
        public double Length { get; set; }
 

        public Metal(int recycleID, string fullName, double weight, int noOfBags,string metalType, double  lenght) : base(recycleID, fullName, weight, noOfBags)
        {
            MetalType = metalType;
            Length = lenght;
           
        }

        public Metal():base()
        {

        }

        public override double CalculatePullCost()
        {
            return (Length * 0.5);
         }

    }
}