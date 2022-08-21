using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19362090_HW04.Models
{
    public abstract class Recycle
    {
        public int RecycleID { get; set; }
        public string FullName { get; set; }
        public double Weight { get; set; }
        public int NoOfBags { get; set; }
                    
   

        public Recycle(int recycleID, string fullName, double weight, int noOfBags)
        {
            RecycleID = recycleID;
            FullName = fullName;
            Weight = weight;
            NoOfBags = noOfBags;

        }
        public Recycle() { }

        public abstract double CalculatePullCost();

        public virtual double TotalWeight()
        {
          return NoOfBags * Weight;
        }




    }
}