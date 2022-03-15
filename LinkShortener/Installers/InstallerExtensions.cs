namespace LinkShortener.Installers
{
    public static class InstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            var installers = typeof(Program).Assembly.ExportedTypes
                .Where(t => typeof(IInstaller).IsAssignableFrom(t) && t.IsClass)
                // Create instance for each one
                .Select(Activator.CreateInstance)
                // Pass them as IInstaller interface
                .Cast<IInstaller>()
                .ToList();

            installers.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
