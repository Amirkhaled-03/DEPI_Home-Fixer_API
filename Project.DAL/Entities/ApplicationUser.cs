﻿using Microsoft.AspNetCore.Identity;

namespace Project.DAL.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
