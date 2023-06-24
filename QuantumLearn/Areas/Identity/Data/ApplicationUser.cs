using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace QuantumLearn.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser  // Ctrl+click to see what's built-in to IdentityUser class; it has built-in ID, username, email, phone, etc.
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte[]? ImageDataForUser { get; set; }  // not required; ? allows for null value

    // validations are in Register.cshtml.cs file
}
