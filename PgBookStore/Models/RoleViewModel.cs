using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PgBookStore.Models
{
    public partial class RoleViewModel{
        [Display(Name ="Role ID")]
        [Required(ErrorMessage = "{0} harus diisi.")]
        public string RoleID { get; set; }
        
        [Display(Name ="Role Name")]
        [Required(ErrorMessage = "{0} harus diisi.")]
        public string RoleName {set; get;}

        [Display(Name ="Description")]
        [Required(ErrorMessage = "{0} harus diisi.")]
        public string Description {set; get;}
    }
}