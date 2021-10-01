using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class SystemRole : IdentityRole<Guid>
    {
        public SystemRole() : base()
        {
        }
        public SystemRole(string roleName)
        {
            Name = roleName;
        }
    }
}
