using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App_Module1.Views
{
    public partial class StylesPage : ContentPage
    {


        public StylesPage()
        {
            InitializeComponent();
            nextButton.Clicked += nextButtonClicked;
            changeStyleButton.Clicked += changeStyleClicked;
            addbuttonButton.Clicked += addButtonClicked;
            Resources["buttonStyle"] = Resources["buttonStyle1"];

        }


		// funcion pra anadir buttones 
        private void addButtonClicked(object sender, EventArgs e)
        {
            var button = new Button
            {
                Text = "New Button",
                BorderColor = Color.Green,
                BorderRadius = 4
            };


            button.SetDynamicResource(VisualElement.StyleProperty, "buttonStyle");

            buttonLayout.Children.Add(button);
        }


		// fucniones para cambiar estilo de lis botones 
        private void changeStyleClicked(object sender, EventArgs e)
        {
            if (Resources["buttonStyle"] == Resources["buttonStyle1"])
            {
                Resources["buttonStyle"] = Resources["buttonStyle2"];
            } else
            {
                Resources["buttonStyle"] = Resources["buttonStyle1"];
            }
        }

        private void nextButtonClicked(object sender, EventArgs e)
        {
            // escribir el codigo para bricar a la anueva pagina 
        }
    }
}
