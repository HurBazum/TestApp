using Microsoft.Extensions.DependencyInjection;

namespace Test.PLL.ViewModels.Services
{
    internal class ViewModelLocator
    {
        public static MainViewModel MainViewModel => App.Host.Services.GetRequiredService<MainViewModel>();
    }
}