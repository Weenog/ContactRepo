﻿using ContactListApp.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ContactListApp.Models
{

    public class ContactEditViewModel
    {

        [DisplayName("First name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name cannot be empty")]
        [MaxLength(25, ErrorMessage = "Maximum 30 characters!")]
        public string FirstName { get; set; }


        [DisplayName("Last name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name cannot be empty")]
        [MaxLength(25, ErrorMessage = "Maximum 30 characters!")]
        public string LastName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "email cannot be empty")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [DisplayName("Birthdate")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }


        [DisplayName("Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }


        [DataType(DataType.MultilineText)]
        [MaxLength(250, ErrorMessage = "Maximum 250 characters!")]
        public string Description { get; set; }
        public string PhotoUrl { get; set; }

        public byte[] FileBytes { get; set; }
        public ContactType ContactType { get; set; }
        public IFormFile Avatar { get; set; }

    }

}