using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.API.Authorization
{
    public class GlobalAdminRequirement : IAuthorizationRequirement
    {
        public GlobalAdminRequirement()
        {

        }
    }
}
