﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication4.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    //Test By Arvind
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  //Test Again
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        } 
    }
}