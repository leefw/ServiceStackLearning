namespace FirstWebService
{
    using System;

    using Funq;

    using ServiceStack.CacheAccess;
    using ServiceStack.CacheAccess.Providers;

    using ServiceStack.WebHost.Endpoints;

    public class HelloAppHost : AppHostBase
    {
        public HelloAppHost()
            : base("Hello Web Services", typeof(HelloService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            Routes.Add<Hello>("/hello").Add<Hello>("/hello/{Name}");

            container.Register<ICacheClient>(new MemoryCacheClient());
        }
    }

    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            new HelloAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}