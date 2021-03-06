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

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Presiding { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Leading { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Pianist { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [Display(Name = "Music Director")]
        public string MusicDirector { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Stake Authority")]
        public string StakeAuthority { get; set; }
        [Display(Name = "Announcement")]
        
        public string EssentialAnnouncements{ get; set; }
        [Display(Name = "First Hymn")]
        public string FirstHymn { get; set; }
        [Display(Name = "First Prayer")]

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string FirstPrayer { get; set; }
        [Display(Name = "Announcement")]
        public string WardAnnouncements { get; set; }
       
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }
        
        
        [Display(Name = "Speaker Subject")]
        public string Speakersubjects { get; set; }
       
        [Display(Name = "Message #1")]
        public string FirstMessagePerson { get; set; }
        
        [Display(Name = "Speaker Subject")]
        public string Speakersubjects2 { get; set; }
        
        [Display(Name = "Message #2")]
        public string SecondMessagePerson { get; set; }
        
        [Display(Name = "Speaker Subject")]
        public string Speakersubjects3 { get; set; }
        [Display(Name = "Message #3")]
        public string ThirdMessagePerson { get; set; }
        [Display(Name = "Last Hymn")]
        public string LastHymn { get; set; }
        [Display(Name = "Last Prayer")]

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string LastPrayer { get; set; }
                
    }
}
