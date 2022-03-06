using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learn_2.Models.Abcent
{
    public class DayType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<DaysOfWeek> DaysOfWeeks { get; set; }
    }
}