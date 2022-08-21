using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19362090_HW04.Models
{
    public static class List
    {
        public static readonly List<Recycle> recycles = new List<Recycle> ();

        public static void Add(Recycle recycle)
        {
            recycles.Add(recycle);
        }

        public static List<Recycle> Recycles()
        {
            return recycles;
        }

        public static void Delete(int id)
        {
           for(int i = 0; i < recycles.Count; i++)
            {
                if (recycles[i].RecycleID == id)
                {
                    recycles.Remove(recycles[i]);
                }
            }
          
        }

        public static void Edit(Recycle recycle)
        {
            if(recycle.GetType () == typeof(Plastic))
            {
                Plastic plastic = (Plastic)recycle;
                for(int i = 0; i < recycles.Count; i++)
                {
                    if(recycles[i].RecycleID == plastic.RecycleID)
                    {
                        recycles[i] = plastic;
                    }
                }
               

            }

            if (recycle.GetType() == typeof(Metal))
            {
                Metal metal = (Metal)recycle;
                for (int i = 0; i < recycles.Count; i++)
                {
                    if (recycles[i].RecycleID == metal.RecycleID)
                    {
                        recycles[i] = metal;
                    }
                }


            }

        }
    }
}