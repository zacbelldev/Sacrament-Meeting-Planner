﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public enum Role
    {
        Bishop, First_Counselor, Second_Counselor
    }

    public class Bishopric
    {
        public int ID { get; set; }
        public Members Name { get; set; }
        public Role Role { get; set; }

        [Display(Name = "Released Flag")]
        public bool? ReleasedFlag { get; set; } = false;

        [Display(Name = "Member ID")]
        public Members Member { get; set; }
    }
}
