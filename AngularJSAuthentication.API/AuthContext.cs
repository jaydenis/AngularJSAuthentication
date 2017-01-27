using AngularJSAuthentication.API.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularJSAuthentication.API
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
     
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<PlayDateEvent> PlayDateEvents { get; set; }
        public DbSet<PlayDateGuestList> PlayDateGuestLists { get; set; }
        public DbSet<PlayDateGuestItem> PlayDateGuestItems { get; set; }
        public DbSet<PlayDateKid> PlayDateKids { get; set; }
        public DbSet<PlayDateFamily> PlayDateFamlies { get; set; }
    }

}