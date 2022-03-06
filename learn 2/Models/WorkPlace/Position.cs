using learn_2.Models.Abcent;
using learn_2.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learn_2.Models.WorkPlace
{
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<DaysOfWeek> DaysOfWeeks{ get; set; }
    }
}