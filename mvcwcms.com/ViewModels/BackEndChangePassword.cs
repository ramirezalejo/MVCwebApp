using MVCwCMS.Models;
using MVCwCMS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MVCwCMS.ViewModels
{
    public class BackEndChangePassword
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
