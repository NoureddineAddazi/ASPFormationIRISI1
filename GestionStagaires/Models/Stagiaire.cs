using System.ComponentModel.DataAnnotations;

namespace GestionStagaires.Models
{
    public class Stagiaire
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nom { get; set; }
        [Required]
        public string? Prénom { get; set; }
        [Required]
        public string? Téléphone { get; set; }
        [Required]
        public string? Entreprise { get; set; }
        [Required]
        public string? Sujet { get; set; }
    }
}
