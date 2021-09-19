using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class Event
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string EventId { get; set; }

        public Game Game { get; set; }
        public int GameId { get; set; }
        public string FeatureEvent { get; set; }
        [Required]
        public string Code { get; set; }
        public int Hours { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public string Description { get; set; }
        public string EventVenue { get; set; }
        public string WorldRecord { get; set; }


    }
}
