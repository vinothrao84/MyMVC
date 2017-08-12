using MyMVC.Areas.Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Areas.User.Models
{
    public class UserModel
    {
        [HiddenInput]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public bool Active { get; set; }

        public virtual InventoryModel Inventory { get; set; }
    }
}