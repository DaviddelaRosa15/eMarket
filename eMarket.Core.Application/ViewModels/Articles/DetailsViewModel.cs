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
    public class DetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrlOne { get; set; }
        public string ImageUrlTwo { get; set; }
        public string ImageUrlThree { get; set; }
        public string ImageUrlFour { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public string NameUser { get; set; }
        public string EmailUser { get; set; }
        public string PhoneUser { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
