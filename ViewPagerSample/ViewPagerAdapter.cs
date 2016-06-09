using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Java.Lang;

using FragmentManager = Android.Support.V4.App.FragmentManager;
using Fragment = Android.Support.V4.App.Fragment;

namespace ViewPagerSample
{
    public class ViewPagerAdapter : FragmentPagerAdapter
    {
        private List<Fragment> fragments;
        private List<string> titles;

        public ViewPagerAdapter(FragmentManager fm) 
            : base(fm)
        {
            this.fragments = new List<Fragment>();
            this.titles = new List<string>();
        }

        public override int Count
        {
            get
            {
                return this.fragments.Count;
            }
        }

        public void AddFragment(Fragment fragment, string title)
        {
            this.fragments.Add(fragment);
            this.titles.Add(title);
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(this.titles[position]);
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return this.fragments[position];
        }
    }
}