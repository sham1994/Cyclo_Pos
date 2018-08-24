

namespace HamburgerMenuSup.ViewModels
{

    public class SettingsViewModel : PropertyChangedViewModel
    {
        private readonly PropertyChangedViewModel _mainViewModel;

        public SettingsViewModel(PropertyChangedViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
    }
}
