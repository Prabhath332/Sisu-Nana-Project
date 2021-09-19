using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class Competitor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FName { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime BirthDay { get; set; }


    }
}
