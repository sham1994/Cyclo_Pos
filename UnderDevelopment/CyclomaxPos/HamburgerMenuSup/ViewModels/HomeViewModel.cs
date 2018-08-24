using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenuSup.ViewModels
{
    public class HomeViewModel : PropertyChangedViewModel
    {
        private readonly PropertyChangedViewModel _mainViewModel;

        public HomeViewModel(PropertyChangedViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
    }
}
