﻿using Microsoft.AspNetCore.Identity;

namespace ChatApp.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
