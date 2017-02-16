using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App_Module1
{
	public partial class ListViewPage : ContentPage
	{
		public List<objeto> unalista = new List<objeto>();

		public ListViewPage()
		{
			InitializeComponent();

			listView.ItemsSource = unalista;

			// este nombre de addButton tengo que ponerlo en el View 
			addButon.clicked += addToList

		}

		public void addToList()
		{
			objeto nuevo = new objeto();
			nuevo.texto = "Texto Nuevo";


			unalista.Add(nuevo);

		}


	} // final de la clase ListViewPage 


	// Otra clase aparte que esta puerta en un NamesSpace 
	public class objeto
	{
		public string texto; 

		// Cosntructor 
		public objeto()
		{
			this.texto = " ";

		}
	}


}
