using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class RegistedStudent
    {
        public int Id { get; set; }
        [NotMapped]
        public Class Class { get; set; }
        public int ClassCode { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
