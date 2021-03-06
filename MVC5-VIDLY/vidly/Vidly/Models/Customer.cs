﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;
using Vidly.CustomValidations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; }


        [Display (Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType  MembershipType  { get; set; }


        [Display (Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}