using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_project.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Teacher { get; set; }
        public string Url { get; set; }
        public int Grade { get; set; }
        public string Subject { get; set; }

        [DataType(DataType.Date)]

        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Advertiesment { get; set; }



    }
}
