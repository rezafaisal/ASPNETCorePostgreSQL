using System;
using System.ComponentModel.DataAnnotations;

namespace PgDatabaseFirst.Models
{
    public class GuestBook{
        [Key]
        public int Id {set; get;}
        public String Name {set; get;}
        public String Email {set; get;}
        public String Message {set; get;}
    }
}