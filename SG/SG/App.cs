using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SG
{
    public class App: Application
    {
        public App( )
        {
            var localizeService = DependencyService.Get<ILocalizeService>();
            localizeService.SetLocale();

            var nameLabel = new Label()
            {
                XAlign = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!",
                Style = AppStyles.LabelStyle
            };


            var entry = new CustomEntry { Placeholder = "Escriba nombre" };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						nameLabel ,
                        entry
					}
                }
            };
        }

        protected override void OnStart( )
        {
            // Handle when your app starts
        }

        protected override void OnSleep( )
        {
            // Handle when your app sleeps
        }

        protected override void OnResume( )
        {
            // Handle when your app resumes
        }
    }
}
