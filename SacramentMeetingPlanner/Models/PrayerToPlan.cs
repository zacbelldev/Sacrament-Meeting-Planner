﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class PrayerToPlan
    {
        [Key]
        public int PrayerToPlanID { get; set; }

        [Display(Name = "Plan")]
        public int? PlansID { get; set; }

        [Display(Name = "Prayer Type")]
        public int PrayerTypeID { get; set; }

        [Display(Name = "Member Name")]
        public int MemberID { get; set; }

        public Plans Plans { get; set; }
        public PrayerType PrayerType { get; set; }
        public Member Member { get; set; }
    }
}