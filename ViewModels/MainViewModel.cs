using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace StarWarsSample.Droid.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowPlanetsViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<FirstViewModel>());
        }

        // MvvmCross Lifecycle

        // MVVM Properties

        // MVVM Commands
        public IMvxAsyncCommand ShowPlanetsViewModelCommand { get; private set; }

        // Private methods
    }
}
