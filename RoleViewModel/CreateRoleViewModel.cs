using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.RoleViewModel
{
    public class CreateRoleViewModel
    {
        [Required(ErrorMessage = "role cannot be empty")]
        public string RoleName { get; set; }
    }
}
