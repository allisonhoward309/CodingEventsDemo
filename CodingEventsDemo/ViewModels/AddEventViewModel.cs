﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage = "Atendees must be between 0 & 100,000")]
        public int NumberAttendees { get; set; }

        public bool IsTrue { get { return true; } }

        [Compare("IsTrue", ErrorMessage = "Registration is required.")]
        public bool RegistrationRequired { get; set; }
    }
}
