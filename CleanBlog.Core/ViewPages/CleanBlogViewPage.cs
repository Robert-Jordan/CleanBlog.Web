using CleanBlog.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using Current = Umbraco.Web.Composing.Current;

namespace CleanBlog.Core.ViewPages
{
    public abstract class CleanBlogViewPage<T> : UmbracoViewPage<T>
    {
        public readonly IArticleService _articleService;
        public CleanBlogViewPage() : this(
            Current.Factory.GetInstance<IArticleService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
            )
        {
        }
        public CleanBlogViewPage(IArticleService articleService, ServiceContext services, AppCaches appCaches)
        {
            _articleService = articleService;
            Services = services;
            AppCaches = appCaches;
        }
    }

    public abstract class CleanBlogViewPage : UmbracoViewPage
    {
        public readonly IArticleService _articleService;
        public CleanBlogViewPage() : this(
            Current.Factory.GetInstance<IArticleService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
            )
        { }

        public CleanBlogViewPage(IArticleService articleService, ServiceContext services, AppCaches appCaches)
        {
            _articleService = articleService;
            Services = services;
            AppCaches = appCaches;
        }
    }
}
