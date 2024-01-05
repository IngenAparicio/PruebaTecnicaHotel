using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Prueba.BL.Services;
using Prueba.Core.Interfaces;
using Prueba.Core.Utilities;
using Prueba.infraestructure.Access;
using Prueba.infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Api
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

            services.AddControllers();

            services.AddTransient<IHotelServices, HotelServices>();
            services.AddTransient<IHotelDataAccess, HotelDataAccess>();

            services.AddTransient<IHabitacionHotelServices, HabitacionHotelServices>();
            services.AddTransient<IHabitacionHotelDataAccess, HabitacionHotelDataAccess>();

            services.AddTransient<IReservaServices, ReservaServices>();
            services.AddTransient<IReservaDataAccess, ReservaDataAccess>();

            services.AddTransient<IReservaHabitacionServices, ReservaHabitacionServices>();
            services.AddTransient<IReservaHabitacionDataAccess, ReservaHabitacionDataAccess>();

            services.AddTransient<IHuespedesReservaServices, HuespedesReservaServices>();
            services.AddTransient<IHuespedesReservaDataAccess, HuespedesReservaDataAccess>();

            // Configuracion Automapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new GlobalMapper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Prueba.Api", Version = "v1" });
            });

            services.AddDbContext<PruebaTecnicaBdContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DataBase")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prueba.Api v1"));
            //}

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
