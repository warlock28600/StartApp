using learn_2.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learn_2.Models.WorkPlace
{
    public class Unit
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<PersonInfo> PersonInfos{ get; set; }
    }
}