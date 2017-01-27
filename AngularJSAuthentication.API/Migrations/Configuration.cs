namespace AngularJSAuthentication.API.Migrations
{
    using AngularJSAuthentication.API.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularJSAuthentication.API.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AngularJSAuthentication.API.AuthContext context)
        {
            if (context.Clients.Count() > 0)
            {
                return;
            }

            context.Clients.AddRange(BuildClientsList());
            context.SaveChanges();
        }

        private static List<Client> BuildClientsList()
        {

            List<Client> ClientsList = new List<Client> 
            {
                new Client
                { Id = "ngAuthApp", 
                    Secret= Helper.GetHash("Kn0wl#dg#"), 
                    Name="AngularJS front-end Application", 
                    ApplicationType =  Models.ApplicationTypes.JavaScript, 
                    Active = true, 
                    RefreshTokenLifeTime = 7200, 
                    AllowedOrigin = "http://localhost:26264/"
                },
                 new Client
                { Id = "mobileApp",
                    Secret= Helper.GetHash("N0v#m3#r"),
                    Name="Cordova front-end Application",
                    ApplicationType =  Models.ApplicationTypes.JavaScript,
                    Active = true,
                    RefreshTokenLifeTime = 7200,
                    AllowedOrigin = "hhttps://myplaydate.azurewebsites.net"
                },
                new Client
                { Id = "consoleApp", 
                    Secret=Helper.GetHash("2nt2rpr!s2"), 
                    Name="Console Application", 
                    ApplicationType =Models.ApplicationTypes.NativeConfidential, 
                    Active = true, 
                    RefreshTokenLifeTime = 14400, 
                    AllowedOrigin = "*"
                }
            };

            return ClientsList;
        }
    }
}
