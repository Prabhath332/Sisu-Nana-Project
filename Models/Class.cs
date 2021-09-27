using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class Class
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int Grade { get; set; }
        public string Subject { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Advertiesment { get; set; }



    }
}
