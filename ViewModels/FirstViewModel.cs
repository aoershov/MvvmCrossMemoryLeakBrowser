using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace StarWarsSample.Droid.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public FirstViewModel(
            IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            OpenSecondViewCommand = new MvxAsyncCommand(OpenSecondView);
        }

        public IMvxCommand OpenSecondViewCommand { get; private set; }

        private async Task OpenSecondView()
        {
            await _navigationService.Navigate<SecondViewModel>();
        }
    }
}
