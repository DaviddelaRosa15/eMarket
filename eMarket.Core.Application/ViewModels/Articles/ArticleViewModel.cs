using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Application.ViewModels.Articles
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrlOne { get; set; }
        public string ImageUrlTwo { get; set; }
        public string ImageUrlThree { get; set; }
        public string ImageUrlFour { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    }
}
