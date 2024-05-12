using Microsoft.Extensions.DependencyInjection;
using Test.DAL.Repositories;
using Test.Interfaces;
using Test.DAL.Entities;
using Test.DAL.Repositories.Base;

namespace Test.DAL
{
    public static class DbInitializer
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services) => services.AddDbContext<TestContext>(ServiceLifetime.Singleton);

        public static IServiceCollection AddRepositories(this IServiceCollection services) => services
            .AddTransient<IRepository<Admin>, Repository<Admin>>()
            .AddTransient<IRepository<Invasion>, Repository<Invasion>>()
            .AddTransient<IRepository<Doctor>, Repository<Doctor>>()
            .AddTransient<IRepository<Patient>, Repository<Patient>>();
    }
}