﻿using System;
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
        [Display(Name = "Music Director")]
        public string MusicDirector { get; set; }
        [Display(Name = "Stake Authority")]
        public string StakeAuthority { get; set; }
        [Display(Name = "Announcement")]
        
        public string EssentialAnnouncements{ get; set; }
        [Display(Name = "First Hymn")]
        public string FirstHymn { get; set; }
        [Display(Name = "First Prayer")]
        public string FirstPrayer { get; set; }
        [Display(Name = "Announcement")]
        public string WardAnnouncements { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }
        
        
        [Display(Name = "Speaker Subject")]
        public string Speakersubjects { get; set; }
        [Display(Name = "Message")]
        public string FirstMessagePerson { get; set; }
        [Display(Name = "Message")]
        public string SecondMessagePerson { get; set; }
        [Display(Name = "Message")]
        public string ThirdMessagePerson { get; set; }
        [Display(Name = "Last Hymn")]
        public string LastHymn { get; set; }
        [Display(Name = "Last Prayer")]
        public string LastPrayer { get; set; }
                
    }
}
