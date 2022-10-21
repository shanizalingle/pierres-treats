using Microsoft.AspNetCore.Identity;
using System;

namespace Bakery.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string ? FullName { get; set; }
  }
}