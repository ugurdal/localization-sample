using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LocalizationSample.ViewModels
{
    public class Create2Vm
    {
        [Required(ErrorMessage = "nameRequired")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
