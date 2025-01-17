﻿using System.ComponentModel.DataAnnotations;

namespace IntroAspPub.Models.ViewModels
{
    public class BeerViewModel
    {
        [Required]
        [Display(Name = "Marca")]
        public int BrandId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
    }
}
