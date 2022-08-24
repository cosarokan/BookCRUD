﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ViewModels
{
    public class BookTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
