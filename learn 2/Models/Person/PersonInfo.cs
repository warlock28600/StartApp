using learn_2.Models.WorkPlace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learn_2.Models.Person
{
    public class PersonInfo
    {
        public int PersonID { get; set; }
        public string Name  { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Position  Position{ get; set; }
        public Unit Unit { get; set; }


    }
}