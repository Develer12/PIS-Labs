using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace entity_VALIDATION.ViewModel
{
    public class PlanViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")] 
        public string Regular { get; set; }
    }
}
