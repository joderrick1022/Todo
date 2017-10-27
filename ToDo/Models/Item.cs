﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Item
    {

        [Key]
        public int ItemId { get; set; } //personal preference for the name ItemID
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Details { get; set; }
        public bool IsDone { get; set; }

    }
    
}