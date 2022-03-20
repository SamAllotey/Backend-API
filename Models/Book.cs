﻿using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class Book
    {
       
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
