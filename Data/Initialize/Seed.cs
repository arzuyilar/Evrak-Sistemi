using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Documents.Models;
using Microsoft.AspNetCore.Identity;

namespace Documents.Data.Initialize
{
    public class Seed
    {
        
        public static async Task Initilize(UserManager<User> _userManager)
        {
            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new User() 
                    { Id = Guid.NewGuid().ToString(),
                        Email = "arzu@gmail.com",
                        UserName = "arzuKubra",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        FirstName = "Arzü",
                        LastName = "Yılar"

                    }, "Aa12345!");
            }
        }
    }
}
