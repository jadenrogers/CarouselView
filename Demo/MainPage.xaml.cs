﻿using System.Collections.ObjectModel;
using System.Diagnostics;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        MainViewModel _vm;

        public MainPage()
        {
            InitializeComponent();

            Title = "CarouselView";

            BindingContext = _vm = new MainViewModel();
        }

        void Handle_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            Debug.WriteLine("Position " + e.NewValue + " selected.");

            if (e.NewValue == 1)
            {
                if (_vm.MyItemsSource[1] is CachedImage ci)
                {
                    ci.Source = "c1.jpg";
                    _vm.MyItemsSource[1] = _vm.MyItemsSource[1];
                }
            }
        }

        void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
            Debug.WriteLine("Scrolled to " + e.NewValue + " percent.");
            Debug.WriteLine("Direction = " + e.Direction);
        }
    }
}
