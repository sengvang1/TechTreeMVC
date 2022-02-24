﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVC.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public int Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }
}