using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learn_2.Models.Person.ModelView
{
    public class PersonViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string  Position { get; set; }
        public string unit { get; set; }
    }
}