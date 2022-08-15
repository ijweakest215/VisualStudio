using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YPANTO_Midterm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewUser : ContentPage
    {
        public NewUser()
        {
            InitializeComponent();
        }
        async void NewUserClicked(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            var data = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("firstname",firstname.Text),
                new KeyValuePair<string, string>("lastname",lastname.Text)
            };
            var cont = new FormUrlEncodedContent(data);
            var resp = await client.PostAsync("http://www.hyeumine.com/newuser.php", cont);
            var returnedResp = resp.Content.ReadAsStringAsync().Result;

            Device.BeginInvokeOnMainThread(async () =>
            {

                var result = await this.DisplayAlert("Congratulation", returnedResp, "Confirm", "Cancel");

                if (result)
                {
                    await Navigation.PushAsync(new NewNote());
                }
            });
        }
    }
}