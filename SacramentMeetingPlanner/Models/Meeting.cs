using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Presiding { get; set; }
        public string Leading { get; set; }
        public string Pianist { get; set; }
        public string MusicDirector { get; set; }
        public string StakeAuthority { get; set; }
        [Display(Name = "Announcement")]
        public string EssentialAnnouncements{ get; set; }
        public string FirstHymn { get; set; }
        public string FirstPrayer { get; set; }
        [Display(Name = "Announcement")]
        public string WardAnnouncements { get; set; }
        public string SacramentHymn { get; set; }
        [Display(Name = "FirstMessage")]
        public string FirstMessagePerson { get; set; }
        [Display(Name = "SecondMessage")]
        public string SecondMessagePerson { get; set; }
        [Display(Name = "ThirdMessage")]
        public string ThirdMessagePerson { get; set; }
        public string LastHymn { get; set; }
        public string LastPrayer { get; set; }
                
    }
}
