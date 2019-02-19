using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Squats
    {
        int set;
        public int Set
        {
            get { return set; }
            set { set=value; }
        }

        int reps;
        public int Reps
        {
            get { return reps; }
            set { reps=value; }
        }

        int weights;
        public int Weights
        {
            get { return weights; }
            set { weights=value; }
        }
        int volume;
        public int Volume {
            get { return volume; }
            set { volume = value; }
        }
        public override string ToString()
        {
            return  Set.ToString();
        }
    }
}
