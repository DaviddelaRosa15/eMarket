using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Application.ViewModels.Categories
{
    public class SaveCategoryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre de la categoria")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe colocar la descripción de la categoria")]
        public string Description { get; set; }
 
    }
}
