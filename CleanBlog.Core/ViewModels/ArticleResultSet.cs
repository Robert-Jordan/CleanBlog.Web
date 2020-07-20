using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace CleanBlog.Core.ViewModels
{
    public class ArticleResultSet
    {
        public IEnumerable<IPublishedContent> Results { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public double PageCount { get; set; }
        public bool IsArticleListPage { get; set; }
        public string Url { get; set; }
    }
}
