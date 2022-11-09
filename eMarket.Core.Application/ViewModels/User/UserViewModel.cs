﻿using eMarket.Core.Application.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<ArticleViewModel> Articles { get; set; }
    }
}