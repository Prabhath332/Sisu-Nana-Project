using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class BaseModel
    {
        public int CreatedUserId {get;set;}
        [DisplayName("Created By")]
        public string CreatedUserName { get; set; }
        [DisplayName("Active")]
        public bool IsInActive { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }

    public class IsSaveModel
    {       
        public bool IsSaved { get; set; }
    }
}
