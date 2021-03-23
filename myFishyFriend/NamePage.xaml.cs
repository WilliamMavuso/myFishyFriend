using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace myFishyFriend
{
    public partial class NamePage : ContentPage
    {
        public NamePage()
        {
            InitializeComponent();
        }

        async void EnterButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new HomePage());
        }
    }
}
