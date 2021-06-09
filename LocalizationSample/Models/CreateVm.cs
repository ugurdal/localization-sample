using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationSample.Models
{
    public class CreateVm
    {
        [Required(ErrorMessage = "nameRequired")]
        public string Name { get; set; }
    }
}
