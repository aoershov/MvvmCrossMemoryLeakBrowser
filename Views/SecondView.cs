using Android.Runtime;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using StarWarsSample.Droid.ViewModels;

namespace StarWarsSample.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("starWarsSample.droid.views.SecondView")]
    public class SecondView : BaseFragment<SecondViewModel>
    {
        protected override int FragmentId => Resource.Layout.SecondView;

    }
}
