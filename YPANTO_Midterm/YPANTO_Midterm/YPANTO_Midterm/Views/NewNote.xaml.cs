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
    public partial class NewNote : ContentPage
    {
        public NewNote()
        {
            InitializeComponent();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var data = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("id",id.Text),
                new KeyValuePair<string, string>("note",note.Text)
            };
            var cont = new FormUrlEncodedContent(data);
            var resp = await client.PostAsync("http://www.hyeumine.com/newnote.php", cont);
            var returnedResp = resp.Content.ReadAsStringAsync().Result;

            Device.BeginInvokeOnMainThread(async () =>
            {

                var result = await this.DisplayAlert("Congratulation", returnedResp, "Confirm", "Cancel");

                if (result)
                {
                }
            });
        }
    }
}