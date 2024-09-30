using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Désignation { get; set; }

        [Required]
        [Display(Name = "Prix en dinar :")]
        public float Prix { get; set; }

        [Required]
        [Display(Name = "Quantité en unité :")]
        public int Quantite { get; set; }

        [Display(Name = "Image :")]
        public string Image { get; set; } // Utilisez Image au lieu de ImagePath pour le stockage

    }
}
