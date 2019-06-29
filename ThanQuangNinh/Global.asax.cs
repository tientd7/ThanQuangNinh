using DAL;
using DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity.AspNet.WebApi;

namespace ThanQuangNinh
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);




            //Migration db
            Configuration configuration = new Configuration();
            configuration.ContextType = typeof(AuthenticationDB);
            var migrator = new DbMigrator(configuration);

            //This will get the SQL script which will update the DB and write it to debug
            //var scriptor = new MigratorScriptingDecorator(migrator);
            //string script = scriptor.ScriptUpdate(sourceMigration: null, targetMigration: null).ToString();
            //Debug.Write(script);

            //This will run the migration update script and will run Seed() method
            migrator.Update();


        }
    }
}
