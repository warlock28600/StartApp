using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learn_2.Models.Abcent
{
    public class DaysOfWeek
    {
        public int ID { get; set; }
        public string DayTitle { get; set; }
        public DayType DayType { get; set; }
    }
}