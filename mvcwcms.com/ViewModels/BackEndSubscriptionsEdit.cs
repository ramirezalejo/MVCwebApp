﻿using MVCwCMS.Helpers;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCwCMS.ViewModels
{
    public class BackEndSubscriptionsEdit
    {
        [DataAnnotationsDisplay("Email")]
        public string Email { get; set; }

        [DataAnnotationsDisplay("Password")]
        [DataAnnotationsStringLengthRange(8, 255)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "PasswordAndConfirmationPasswordDoNotMatch")]
        [DataAnnotationsDisplay("ConfirmationPassword")]
        [DataAnnotationsStringLengthMax(255)]
        public string ConfirmationPassword { get; set; }

        [DataAnnotationsDisplay("FirstName")]
        [DataAnnotationsRequired]
        [DataAnnotationsStringLengthMax(255)]
        public string FirstName { get; set; }

        [DataAnnotationsDisplay("LastName")]
        [DataAnnotationsRequired]
        [DataAnnotationsStringLengthMax(255)]
        public string LastName { get; set; }

        [DataAnnotationsDisplay("Birthdate")]
        public string Birthdate { get; set; }

        [DataAnnotationsDisplay("PhoneNumber")]
        [DataAnnotationsStringLengthMax(255)]
        public string PhoneNumber { get; set; }

        [DataAnnotationsDisplay("Address")]
        [DataAnnotationsStringLengthMax(255)]
        public string Address { get; set; }

        [DataAnnotationsDisplay("City")]
        [DataAnnotationsStringLengthMax(255)]
        public string City { get; set; }

        [DataAnnotationsDisplay("PostCode")]
        [DataAnnotationsStringLengthMax(255)]
        public string PostCode { get; set; }

        [DataAnnotationsDisplay("Country")]
        [DataAnnotationsStringLengthMax(2)]
        public string CountryCode { get; set; }

        [DataAnnotationsDisplay("Status")]
        [DataAnnotationsRequired]
        public int SubscriptionStatusId { get; set; }

        [DataAnnotationsDisplay("JoinNewsletter")]
        public bool WantsNewsletter { get; set; }

        [DataAnnotationsDisplay("JoinDate")]
        public string JoinDate { get; set; }

        [DataAnnotationsDisplay("Notes")]
        [DataAnnotationsStringLengthMax(1000)]
        public string Notes { get; set; }
    }
}
