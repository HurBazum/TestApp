using Test.PLL.ViewModels.Base;

namespace Test.PLL.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _title = "Test.StartPage";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }


    }
}