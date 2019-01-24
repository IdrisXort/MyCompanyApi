using ApiCompany.Business.BusinessInterfaces;
using ApiCompany.Business.BusinessModels;
using ApiCompany.Domein;
using ApiCompany.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;

namespace ApiCompany
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<ApiDbContext>(options =>
                          options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IProcessable<Project>,B_Project>();
            services.AddTransient<IProcessable<Skill>, B_Skill>();
            services.AddTransient<IProcessable<User>, B_User>();

            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Info { Title = "APICompany", Version = "v1" }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            }); ;
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
