using Microsoft.OpenApi.Models;

namespace LinkShortener.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddMvcCore();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Link Shortener",
                    Version = "v1",
                });
            });
        }
    }
}
