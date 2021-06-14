using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using StudentCore.Core.IRepository;
using StudentCore.Core.IServices;
using Student.Services.Services;
using Student.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student.Utilities
{
    public static class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Context accesor
            // this is for accessing the http context by interface in view level
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region Services

            services.AddScoped<ITestServices, TestService>();

            #endregion

            #region Repository

            services.AddScoped<ITestRepository, TestRepository>();

            #endregion

        }
    }
}
