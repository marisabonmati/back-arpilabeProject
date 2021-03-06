﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

public enum Departement
{
    IT,
    Marketing,
    Commerce
}

namespace back_arpilabeProject.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public Departement Departement { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        public DateTime DateDeNaissance { get; set; }

    }
}
