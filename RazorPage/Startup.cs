using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace sourcestack1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //���µ�ҳ��/Article/Single? id = 1 => /Article/1
        //�����޸ģ�/Article/Edit? id = 7 => /Article/Edit/7
        //���������б�/Article/Index? pageIndex = 3 => /Article/Page-3
        //���·����б�/Article/IndexOfCategory? pageIndex = 3 & category = 1 => /Article/Category-1/Page-3
        //���������б�/Article/IndexOfAuthor? author = 5 & pageIndex = 2 => /Article/User-5/Page-2
        //������ʷ�¼�¼��/Task/HistoryOfMonth? year = 2019 & month = 8 & id = 5 => /Task/History/5/2019/8
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages()
                .AddRazorPagesOptions(opt =>
                {
                    opt.Conventions.AddPageRoute("/Article/Single? id = 1", "/Article/1");
                //opt.Conventions.AddPageRoute("/Article/Edit? id = 7", "/Article/Edit/7");
                //opt.Conventions.AddPageRoute("/Article/Index? pageIndex = 3", "/Article/Page-3");
                //opt.Conventions.AddPageRoute("/Article/IndexOfCategory? pageIndex = 3 & category = 1 ", "/Article/Category-1/Page-3");
                //opt.Conventions.AddPageRoute("/Article/IndexOfAuthor? author = 5 & pageIndex = 2", "/Article/User-5/Page-2");
                //opt.Conventions.AddPageRoute("/Task/HistoryOfMonth? year = 2019 & month = 8 & id = 5", "/Task/History/5/2019/8");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
