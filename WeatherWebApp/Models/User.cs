﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WeatherWebApp.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<UserCity> UserCities { get; set; }
    }
}