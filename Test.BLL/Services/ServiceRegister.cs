using Microsoft.Extensions.DependencyInjection;
using Test.Interfaces;
using Test.DAL.Entities;

namespace Test.BLL.Services
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IEntityService<Admin>, EntityService<Admin>>()
            .AddTransient<IEntityService<Invasion>, EntityService<Invasion>>()
            .AddTransient<IEntityService<Doctor>, EntityService<Doctor>>()
            .AddTransient<IEntityService<Patient>, EntityService<Patient>>();

    }
}