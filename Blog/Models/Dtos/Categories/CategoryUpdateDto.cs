﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Dtos.Categories
{
    public class CategoryUpdateDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(250)]
        public string? Description { get; set; } = null!;
    }
}