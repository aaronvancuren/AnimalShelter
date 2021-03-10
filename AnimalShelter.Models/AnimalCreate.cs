﻿using AnimalShelter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Models
{
    public class AnimalCreate
    {
        public string Name { get; set; }
        [Required]
        public SpeciesType Species { get; set; }
        public string Breed { get; set; }
        [Required]
        public bool Sex { get; set; }
        [Required]
        public bool Fixed { get; set; }
        public bool HasShots { get; set; }
        [Required]
        public string Age { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal AdoptionPrice { get; set; }
        public bool IsHouseTrained { get; set; } = false;
        public bool IsDeclawed { get; set; } = false;
        public bool IsEdible { get; set; } = false;
    }
}