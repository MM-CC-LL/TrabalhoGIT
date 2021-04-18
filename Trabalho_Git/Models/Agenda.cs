using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Git.Models
{
    public class Agenda
    {
        public int Id { get; set; }

        public DateTime Horario { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
