using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2
{
    public class Course
    {

        public int Id;
        public string Name;
        public int duration;
        public double fees;



        public Course(int Id, string Name, int duration, double fee)
        {
            this.Id = Id;
            this.Name = Name;
            this.duration = duration;
            this.fees = fee;
        }
    }
}
