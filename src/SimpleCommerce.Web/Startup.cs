using System;
using System.Globalization;
using System.Reflection;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleCommerce.Core.ApplicationServices;
using SimpleCommerce.Core.Domain.Models;
using SimpleCommerce.Core.Infrastructure.EntityFramework;
using SimpleCommerce.Web.Extensions;
using SimpleCommerce.Web.RouteConfigs;
using Autofac.Extensions.DependencyInjection;
using SimpleCommerce.Infrastructure.Domain.IRepositories;

namespace SimpleCommerce.Web
{
    public class Startup
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public Startup(IHostingEnvironment env)
        {
            hostingEnvironment = env;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            GlobalConfiguration.ConnectionString = Configuration["Data:DefaultConnection:ConnectionString"];
            GlobalConfiguration.ApplicationPath = hostingEnvironment.WebRootPath;

            services.AddDbContext<SimpleDbContext>(options =>
            {
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    b=>b.MigrationsAssembly("SimpleCommerce.Web"));
            });

            services.AddIdentity<User, Role>(configure =>
            {
                configure.Cookies.ApplicationCookie.LoginPath ="/login";
            }).AddEntityFrameworkStores<SimpleDbContext, long>()
            .AddDefaultTokenProviders();

            services.AddScoped<SignInManager<User>, SimpleSignInManager<User>>();

           

            // Add framework services.
            services.AddMvc()
                .AddViewLocalization(options => options.ResourcesPath = "Resources")
                .AddDataAnnotationsLocalization();

            services.AddScoped(f => Configuration);
            //services.AddScoped<IWorkContext, WorkContext>();

            GlobalConfiguration.Modules.Add(new HvModule { Name = "Core", AssemblyName = "SimpleCommerce.Core" });
            GlobalConfiguration.Modules.Add(new HvModule { Name = "Cms", AssemblyName = "SimpleCommerce.Cms" });
            //GlobalConfiguration.Modules.Add(new HvModule { Name = "Orders", AssemblyName = "SimpleCommerce.Orders" });

            var builder = new ContainerBuilder();

            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>));

            builder.RegisterGeneric(typeof(RepositoryWithTypedId<,>)).As(typeof(IRepositoryWithTypedId<,>));
            foreach (var module in GlobalConfiguration.Modules)
            {
                builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName(module.AssemblyName))).AsImplementedInterfaces();
            }

            builder.RegisterInstance(Configuration);
            builder.RegisterInstance(hostingEnvironment);
            //builder.RegisterMediaType(Configuration["Storage:StorageType"]);


            builder.Populate(services);
            var container = builder.Build();
            return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
               // app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            var supportedCultures = new[]
            {
                new CultureInfo("en-US")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture =
                    new Microsoft.AspNetCore.Localization.RequestCulture(culture: "en-US", uiCulture: "en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });



            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.Routes.Add(new GenericRule(routes.DefaultHandler));

                routes.MapRoute("areaRoute",
                    "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
