using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlaceManager.Data.Repositories;

namespace PlaceManager.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPlaceRepository, PlaceRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<PlaceDbContext>(opt => opt
               .UseSqlServer(@"Data Source=YASMINE-PC\MAINSQLSERVER;Initial Catalog=PlacesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            return services;
        }

 
    }
}
