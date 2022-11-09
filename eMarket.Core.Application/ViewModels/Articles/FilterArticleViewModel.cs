using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Application.ViewModels.Articles
{
    public class FilterArticleViewModel
    {
        public int[] CategoryId { get; set; }
        public string ArticleName { get; set; }
    }
}
