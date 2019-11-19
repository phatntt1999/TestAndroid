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

namespace TestWithGiasutinhocGuide.Resources.Profile
{
    class Profile
    {
        private string _Name;
        private int _Age;

        public Profile (string name, int age)
        {
            _Name = name;
            _Age = age;
        }

        public string getName()
        {
            return _Name;
        }

        public int getAge()
        {
            return _Age;
        }
    }
}