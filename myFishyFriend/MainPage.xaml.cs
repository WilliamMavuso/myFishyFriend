using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace myFishyFriend
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void StartButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NamePage());
        }




    }
}
