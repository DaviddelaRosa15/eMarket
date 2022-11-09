using eMarket.Core.Application.ViewModels.Categories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Application.ViewModels.Articles
{
    public class SaveArticleViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre del articulo")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        public string ImageUrlOne { get; set; }

        [DataType(DataType.Text)]
        public string ImageUrlTwo { get; set; }

        [DataType(DataType.Text)]
        public string ImageUrlThree { get; set; }

        [DataType(DataType.Text)]
        public string ImageUrlFour { get; set; }

        [Required(ErrorMessage = "Debe colocar una descripción del articulo")]
        [DataType(DataType.Text)]
        public string Description { get; set; }     

        [Required(ErrorMessage = "Debe colocar el precio del articulo")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe colocar la categoria del articulo")]      
        public int CategoryId { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
                
        [DataType(DataType.Upload)]
        public IFormFile ImageOne{ get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageTwo { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageThree { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile ImageFour { get; set; }

        public int UserId { get; set; }
    }
}
