using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;

using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace ViewPagerSample
{
    [Activity(Label = "ViewPagerSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        private Toolbar toolbar;
        private TabLayout tabLayout;
        private ViewPager viewPager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            this.toolbar = this.FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(this.toolbar);

            this.viewPager = this.FindViewById<ViewPager>(Resource.Id.viewpager);
            this.FillViewPager();

            this.tabLayout = this.FindViewById<TabLayout>(Resource.Id.tabs);
            this.tabLayout.SetupWithViewPager(this.viewPager);
        }

        private void FillViewPager()
        {
            ViewPagerAdapter adapter = new ViewPagerAdapter(SupportFragmentManager);
            adapter.AddFragment(new CityFragment(), "Trento");
            adapter.AddFragment(new CityFragment(), "Rovereto");
            adapter.AddFragment(new CityFragment(), "Riva del Garda");
            this.viewPager.Adapter = adapter;
        }
    }
}

