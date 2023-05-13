using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using DataAccess;
using Forum.Domain.Interfaces;
using Forum.Domain.Repositories;
using Forum.Domain.Services;
using Forum.Extensions;
using ICommentRepository = Forum.Domain.Interfaces.ICommentRepository;

namespace Forum
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.Configure<CloudinaryOptions>(Configuration.GetSection("Cloudinary"));

            services.AddScoped<HandleExceptionsActionFilterAttribute>();

            services.AddDbContext<ForumContext>(options => options.UseSqlServer(
                Environment.GetEnvironmentVariable("ForumContext")!));

            services.AddHttpContextAccessor();

            services.AddControllers(options => { options.AllowEmptyInputInBodyModelBinding = true; })
                .AddNewtonsoftJson().AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                });


            var origins = Environment.GetEnvironmentVariable("ALLOWED_ORIGINS")!.Split(";");

            services.AddCors(policyBuilder =>
                policyBuilder.AddDefaultPolicy(policy =>
                    policy.WithOrigins(origins).AllowAnyHeader().AllowAnyHeader().WithMethods("*"))
            );

            //Repositories
            services.AddScoped<ICommentRepository, ICommentRepository>();
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<ICommentService, CommentService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
            });
        }
    }
}