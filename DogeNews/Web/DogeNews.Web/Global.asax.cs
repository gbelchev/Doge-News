﻿using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

using DogeNews.Web.App_Start;
using DogeNews.Web.Providers.Contracts;

using Ninject;

namespace DogeNews.Web
{
    public class Global : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BindingsConfig.BindPresenterFactory();

            var mapperProvider = NinjectWebCommon.Kernel.Get<IMapperProvider>();
            (new MappingsConfig(mapperProvider)).Map();
        }

        public void Application_Error(object sender, EventArgs e)
        {
            var serverError = this.Server.GetLastError() as HttpException;

            if (serverError.ErrorCode == 404)
            {
                this.Server.ClearError();
                this.Server.Transfer("~/Errors/404Page.aspx");
            }
        }
    }
}