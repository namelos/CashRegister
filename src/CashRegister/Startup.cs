using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegister.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CashRegister
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app) => 
            app.UseMvc();

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IItemConfigRepository, ItemConfigRepository>();
            services.AddMvc();
        }
    }
}
