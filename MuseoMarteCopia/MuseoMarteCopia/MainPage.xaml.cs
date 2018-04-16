using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MuseoMarteCopia
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{

            InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {

                Navigation.PushAsync(new Page1());
                //DisplayAlert("Alert", "Activaste una imagen", "OK");

            };
            imagen1.GestureRecognizers.Add(tapGestureRecognizer);
        }
	}
}
