using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class GarageDataSeed
    {
        public static async Task SeedData(GarageDataContext context)
        {
            if (context.GarageUsers.Any()) return;
            
            var garageUsers = new List<GarageUser>
            {
                new GarageUser
                {
                    Name = "Almog Naftaly",
                    DateCreated = DateTime.Now.Date,
                    LastLoginDate = DateTime.Now.Date,
                    CarRecieved = DateTime.Now.Date.AddDays(3),
                    CarNumber = 5809455,
                    Catagory = "Jeep",
                    ClientInsurance = "Harel",
                    ClientAgent = "Roy elbachar",
                    Admin = true
                },
                new GarageUser
                {
                    Name = "Meir Naftaly",
                    DateCreated = DateTime.Now.Date,
                    LastLoginDate = DateTime.Now.Date,
                    CarRecieved = DateTime.Now.Date.AddDays(3),
                    CarNumber = 7890488,
                    Catagory = "Private",
                    ClientInsurance = "Migdal",
                    ClientAgent = "Efrat elbachar",
                    Admin = true
                }
            };

            await context.GarageUsers.AddRangeAsync(garageUsers);
            await context.SaveChangesAsync();
        }
    }
}