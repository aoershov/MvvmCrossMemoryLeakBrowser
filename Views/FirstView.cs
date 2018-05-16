using Android.Runtime;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using StarWarsSample.Droid.ViewModels;

namespace StarWarsSample.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, false)]
    [Register("starWarsSample.droid.views.FirstView")]
    public class FirstView : BaseFragment<FirstViewModel>
    {
        protected override int FragmentId => Resource.Layout.FirstView;
    }
}
