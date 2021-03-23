using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//name of the digital space that you're creating.
namespace myFishyFriend
{

    // defualt Application object which extends the App class (category), with the 'public' and 'partial' keywords.
    // this is how to tell which class of the namespace project that you're in.
    // this class contains/extends a different class called Application in order to use some its methods and fields.
    public partial class App : Application
    {

        // constructor declaration that will be executed everytime a new instance of this program is created
        // 1. invoke the predefined InitialiseComponent function
        // 2. set/assign the mainpage variable to a MainPage() object using the new keyword.
        // this is where your program gets executed.
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
