using System;

using Xamarin.Forms;

namespace App_Module1
{
	public class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

