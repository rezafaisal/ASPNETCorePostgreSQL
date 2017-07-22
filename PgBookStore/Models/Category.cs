using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PgBookStore.Models
{
    public partial class Category{
        [Display(Name ="ID")]
        [Required(ErrorMessage = "{0} harus diisi.")]
        public int CategoryID {set; get;}
        
        [Display(Name ="Book Category Name")]
        [Required(ErrorMessage = "{0} harus diisi.")]
        [StringLength(256, ErrorMessage = "{0} tidak boleh lebih {1} karakter.")]
        public String Name {set; get;}

        public ICollection<Book> Books { get; set; } 
    }
}