﻿using nexus.protocols.ble;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OmniCore.Mobile
{
    public partial class App : Application
    {
        public App(IBluetoothLowEnergyAdapter ble)
        {
            InitializeComponent();

            MainPage = new MainPage(ble);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
