using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLSV.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string rollNumber { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string birthday { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string avatar { get; set; }


    }
}