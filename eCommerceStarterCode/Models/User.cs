﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }    


    }
}
