﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeedAggregator.Web.UI.Startup))]
namespace FeedAggregator.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
