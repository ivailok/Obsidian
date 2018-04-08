using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using Obsidian.Core;
using Obsidian.Core.Contracts;

namespace Obsidian.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<ISqliteConnectionService, AndroidSqliteConnectionService>();
        }
    }
}