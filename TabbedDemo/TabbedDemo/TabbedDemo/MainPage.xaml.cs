﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedDemo
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGoPage1_Clicked(object sender, EventArgs e)
        {
            NaviPage.Navigation.PushAsync(new Page1());
        }
    }
}