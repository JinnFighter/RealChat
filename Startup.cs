using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealChat.Hubs;

namespace RealChat
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endPoints =>
            {
                endPoints.MapHub<ChatHub>("/chat"); 
            });
        }
    }
}