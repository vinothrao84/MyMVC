using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Areas.Inventory.Models
{
    public class InventoryModel
    {
        [HiddenInput]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Amount { get; set; }
        public int OwnedBy { get; set; }

        public virtual UserContext User { get; set; }
    }
}