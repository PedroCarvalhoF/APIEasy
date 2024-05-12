﻿using Microsoft.AspNetCore.Identity;

namespace Domain.Identity.UserIdentity
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}