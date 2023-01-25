using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ("Obrigatorio preencher"))]
        [Display(Name = ("Id Ingame"))]
        public int IdGame { get; set; }

        [Required(ErrorMessage = ("Obrigatorio preencher"))]
        [Display(Name = ("Nome Ingame"))]
        public string Nome { get; set; }

        [Display(Name = ("Sobrenome Ingame"))]
        [Required(ErrorMessage = ("Obrigatorio preencher"))]
        public string Sobrenome { get; set; }

        [Display(Name = ("Telefone Ingame"))]
        [Required(ErrorMessage = ("Obrigatorio preencher"))]
        public string Telefone { get; set; }

        [Display(Name = ("OAB Ingame"))]
        [Required(ErrorMessage = ("Obrigatorio preencher"))]
        public int OAB { get; set; }

    }
}
