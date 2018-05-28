using MVCwCMS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCwCMS.ViewModels
{
    public class FrontEndSubscriptionPasswordChange
    {
        [DataAnnotationsDisplay("CurrentPassword")]
        [DataAnnotationsRequired]
        [DataAnnotationsStringLengthMax(255)]
        public string CurrentPassword { get; set; }

        [DataAnnotationsDisplay("NewPassword")]
        [DataAnnotationsRequired]
        [DataAnnotationsStringLengthRange(8, 255)]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "NewPasswordAndConfirmationPasswordDoNotMatch")]
        [DataAnnotationsDisplay("ConfirmationPassword")]
        [DataAnnotationsRequired]
        public string ConfirmationPassword { get; set; }
    }
}