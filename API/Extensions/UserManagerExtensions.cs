using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Entities.identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class UserManagerExtensions //when declearing static class we dont have to create an object to call its methods
    {
        public static async Task<AppUser> FindByUserByClaimsPrincipleWithAddressAsync(this UserManager<AppUser>
        input, ClaimsPrincipal user)
        {
            var email= user?.Claims?.FirstOrDefault(x =>x.Type == ClaimTypes.Email)?.Value;

            return await input.Users.Include(x =>x.Address).SingleOrDefaultAsync(x =>x.Email ==email);

        }
        public static async Task<AppUser> FindByEmailFromClaimsPrinciple(this UserManager<AppUser>
        input,ClaimsPrincipal user)
        {
            var email= user?.Claims?.FirstOrDefault(x =>x.Type == ClaimTypes.Email)?
            .Value;
            return await input.Users.SingleOrDefaultAsync(x =>x.Email ==email);
        }

    }
}