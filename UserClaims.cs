//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Options;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using web_project.Models;

//namespace web_project
//{
//    public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<SystemUser>
//    {
//        public MyUserClaimsPrincipalFactory(
//            UserManager<SystemUser> userManager,
//            IOptions<IdentityOptions> optionsAccessor)
//            : base(userManager, optionsAccessor)
//        {
//        }

//        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(SystemUser user)
//        {
//            var identity = await base.GenerateClaimsAsync(user);
//            identity.AddClaim(new Claim("tenantId", user.TenantId.ToString()));
//            return identity;
//        }
//    }
//}
