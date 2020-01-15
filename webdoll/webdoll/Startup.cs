using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; //add
using webdoll.Models;                //add

namespace webdoll
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // このメソッドはRuntimeによって呼び出されます。このメソッドを使用して、コンテナにサービスを追加します。
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // このメソッドはRuntimeによって呼び出されます。 このメソッドを使用して、HTTPrequestパイプラインを構成します。
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

            //静的fileを提供し、既定のファイルマッピングを有効にする
            app.UseDefaultFiles();   
            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
