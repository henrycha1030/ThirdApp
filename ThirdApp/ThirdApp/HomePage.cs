using System;
using Xamarin.Forms;

namespace ThirdApp
{
    public class HomePage : ContentPage
    {

        public HomePage()
        {
            Label label = new Label
            {
                Text = "This is a button"
            };
            Button button = new Button()
            {
                Text = "Click me"
            };
            StackLayout stack = new StackLayout();
            stack.Children.Add(label);
            stack.Children.Add(button);
            Content = stack;

            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            IDisplayAlert display = DependencyService.Get<IDisplayAlert>();
            if (display != null)
            { display.DisplayAlert(); };
        }
    }
    }