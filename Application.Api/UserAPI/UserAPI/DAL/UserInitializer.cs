using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserAPI.Models;

namespace UserAPI.DAL
{
    public class UserInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Bat",LastName="Man"},
                new User{FirstName="Killer",LastName="Croc"},
                new User{FirstName="John",LastName="Smith"},
                new User{FirstName="Agent",LastName="Smith"},
                new User{FirstName="Smith",LastName="Wesson"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}