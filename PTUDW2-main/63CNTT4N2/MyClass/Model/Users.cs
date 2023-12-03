﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    //khai bao ten bang
    [Table("Users")]
    public class Users
    {
        // khai bao truong, khoa chinh
        [Key]
        public int Id { get; set; }
        [Required]// khong dc null
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
       
        public string Img { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Role { get; set; }
    
        public string Address { get; set; }
       
        public DateTime CreateAt { get; set; }
       
        public int? CreateBy { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int? UpdateBy { get; set; }

        public int? Status { get; set; }
    }
}
