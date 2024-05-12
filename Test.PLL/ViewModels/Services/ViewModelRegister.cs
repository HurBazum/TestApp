using Microsoft.Extensions.DependencyInjection;

namespace Test.PLL.ViewModels.Services
{
    public static class ViewModelRegister
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddTransient<MainViewModel>();
    }
}