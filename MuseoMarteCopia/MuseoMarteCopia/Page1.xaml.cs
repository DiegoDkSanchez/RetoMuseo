using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Net.Http;
using System.Net.Http.Headers;
using MuseoMarteCopia.ViewModel;

namespace MuseoMarteCopia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        PublicacionViewModel vm;
		public Page1 ()
		{
			InitializeComponent ();

            vm = new PublicacionViewModel();
            

        }
	}
}