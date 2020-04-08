using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
    public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                //Look for any meeting
                if (context.Meeting.Any())
                {
                    return; //DB has been seeded.
                }
                context.Meeting.AddRange(
                    new Meeting
                    {
                        Date = DateTime.Parse("2019-12-12"),
                        Presiding = "Marco Bustillos",
                        Leading = "Alexander Calva",
                        Pianist = "Carlos Alonzo",
                        MusicDirector = "Victor Alonzo",
                        StakeAuthority = "Leonel Messi",
                        EssentialAnnouncements = "Confirmation of two members",
                        FirstHymn = "#41 - Let Zion in Her Beauty Rise",
                        FirstPrayer = "Joseph Smith",
                        WardAnnouncements = "Temple travel",
                        SacramentHymn = "#40-Arise, O Glorious Zion",
                        Speakersubjects = "Atonement",
                        FirstMessagePerson = "Raul Rodriguez",
                        Speakersubjects2 = "Fasting",
                        SecondMessagePerson = "Paul McCartney",
                        Speakersubjects3 = "Repentance",
                        ThirdMessagePerson = "John Lennon",
                        LastHymn = "#39-O Saints of Zion",
                        LastPrayer = "Rafael Correa"
                    },
                    new Meeting
                    {
                        Date = DateTime.Parse("2010-1-11"),
                        Presiding = "John Lennon",
                        Leading = "Paul McCartney",
                        Pianist = "Carlos Alonzo",
                        MusicDirector = "Victor Alonzo",
                        StakeAuthority = "Michelle",
                        EssentialAnnouncements = "Conference next week",
                        FirstHymn = "#41 - Let Zion in Her Beauty Rise",
                        FirstPrayer = "Joseph Smith",
                        WardAnnouncements = "Come Follow Me - new Manual",
                        SacramentHymn = "#40-Arise, O Glorious Zion",
                        Speakersubjects = "Restoration",
                        FirstMessagePerson = "Raul Rodriguez",
                        Speakersubjects2 = "Priesthood",
                        SecondMessagePerson = "Chopin",
                        Speakersubjects3 = "Book of Mormon",
                        ThirdMessagePerson = "Mark Zuckenberg",
                        LastHymn = "#39-O Saints of Zion",
                        LastPrayer = "Lenin Moreno"
                    },
                    new Meeting
                    {
                        Date = DateTime.Parse("2019-12-12"),
                        Presiding = "Mark Zuckenberg",
                        Leading = "Bill Gates",
                        Pianist = "Donald Trump",
                        MusicDirector = "Hilary",
                        StakeAuthority = "Ferdinand Nkenta",
                        EssentialAnnouncements = "Family History",
                        FirstHymn = "#41 - Let Zion in Her Beauty Rise",
                        FirstPrayer = "John",
                        WardAnnouncements = "Ministering",
                        SacramentHymn = "#40-Arise, O Glorious Zion",
                        Speakersubjects = "Sacrament",
                        FirstMessagePerson = "Raul Rodriguez",
                        Speakersubjects2 = "Church attending",
                        SecondMessagePerson = "Paul McCartney",
                        Speakersubjects3 = "Service",
                        ThirdMessagePerson = "John Lennon",
                        LastHymn = "#39-O Saints of Zion",
                        LastPrayer = "Apple"
                    }

                    );
                context.SaveChanges();
            }
        }
      }
}
