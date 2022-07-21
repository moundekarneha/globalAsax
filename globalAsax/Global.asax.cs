using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace globalAsax
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["count"] = 0;
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Application_End(object sender, EventArgs e)
        {

        }
        void Application_Error(object sender, EventArgs e)
        {
            
        }
        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Application["count"] = (int)Application["count"] + 1;
            Session["name"] = "Guest";


        }
        void Session_End(object sender, EventArgs e)
        {
            // Code that runs on application startup
           
        }
    }
}