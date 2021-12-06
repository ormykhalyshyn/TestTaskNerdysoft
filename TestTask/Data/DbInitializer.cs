using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataBContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Announcements.Any())
            {
                return;   // DB has been seeded
            }

            var announcements = new Announcement[]
            {
            new Announcement{Name="Qwerty",Description="QwertyQwerty",DateofCreation=DateTime.Parse("2021-12-06")},
            new Announcement{Name="Qwerty2",Description="QwertyQwerty2",DateofCreation=DateTime.Parse("2021-12-06")},
            new Announcement{Name="Qwerty3",Description="QwertyQwerty3",DateofCreation=DateTime.Parse("2021-12-06")},
            new Announcement{Name="Qwerty4",Description="QwertyQwerty4",DateofCreation=DateTime.Parse("2021-12-06")},
            };
            foreach (Announcement i in announcements)
            {
                context.Announcements.Add(i);
            }
            context.SaveChanges();
        }
    }
}
