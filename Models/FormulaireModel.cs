using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        [Required(ErrorMessage = "Donnée obligatoire.")] public string? Nom { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] public string? Prenom { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] public string? Sexe { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] public string? Adresse { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] [RegularExpression(@"[0-9]{5}", ErrorMessage = "Le format n'est pas bon")] public int? CodePostal { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] public string? Ville { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "Le format n'est pas bon")] public string? Mail { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] public DateOnly? DateDebFormation { get; set; }
        [Required(ErrorMessage = "Donnée obligatoire.")] public string? TypeFormation { get; set; }
        [Required(ErrorMessage = "Donnéee obligatoire.")] public string? Cobol { get; set; }
        [Required(ErrorMessage = "Donnéee obligatoire.")] public string? Csharp { get; set; }
    }
}
