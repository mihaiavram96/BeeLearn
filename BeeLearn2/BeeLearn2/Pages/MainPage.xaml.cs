using System;
using Xamarin.Forms;
using BeeLearn2;
using Xamarin.Forms.Xaml;


namespace BeeLearn2.Pages
    {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            
		}

		async void OnLogoutButtonClicked (object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore (new LoginPage (), this);
			await Navigation.PopAsync ();
		}
        
        
        async void OnQuizButtonClicked(object sender, EventArgs e)
            {

            await Navigation.PushAsync(new QuizPage());
            }
        async void OnAssistantButtonClicked(object sender, EventArgs e)
            {

            await Navigation.PushAsync(new AssistantPage());
            }
        async void OnLearnButtonClicked(object sender, EventArgs e)
            {

            await Navigation.PushAsync(new LearnPage());
            }
        }
}
