using MvvmCross.Core.ViewModels;
using Obsidian.Core.ViewModels;

namespace Obsidian.Core
{
    class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
