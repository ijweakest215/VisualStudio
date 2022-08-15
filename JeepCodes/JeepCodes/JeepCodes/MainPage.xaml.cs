using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JeepCodes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSearch(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string str = searchText.Text;

            var jeeplist = new string[15]
            {
                  "01A",
                  "02B",
                  "03C",
                  "04A",
                  "04D",
                  "06B",
                  "06D",
                  "10C",
                  "10H",
                  "11A",
                  "11B",
                  "20A",
                  "20C",
                  "42C",
                  "42D",
            };
            string[][] route = new string[15][];

            route[0] = new string[5]
            {
                "alpha", "bravo", "charlie", "echo", "golf"
            };

            route[1] = new string[5]
            {
                "alpha", "delta", "echo", "foxtrot", "golf"
            };


            route[2] = new string[5]
            {
               "charlie", "delta", "foxtrot", "hotel", "india"
            };


            route[3] = new string[5]
            {
               "charlie", "delta", "echo", "foxtrot", "golf"
            };


            route[4] = new string[5]
            {
                "charlie", "echo", "foxtrot", "golf", "india"
            };


            route[5] = new string[5]
            {
               "delta", "hotel", "juliet", "kilo", "lima"
            };


            route[6] = new string[5]
            {
               "delta", "foxtrot", "golf", "india", "kilo"
            };


            route[7] = new string[5]
            {
               "foxtrot", "golf", "hotel", "india", "juliet"
            };


            route[8] = new string[5]
            {
               "foxtrot", "hotel", "juliet", "lima", "november"
            };


            route[9] = new string[5]
            {
               "foxtrot", "golf", "kilo", "mike", "november"
            };


            route[10] = new string[5]
            {
               "foxtrot", "golf", "lima", "oscar", "papa"
            };


            route[11] = new string[5]
            {
              "india", "juliet", "november", "papa", "romeo"
            };


            route[12] = new string[5]
            {
               "india", "kilo", "lima", "mike", "romeo"
            };


            route[13] = new string[5]
            {
              "juliet", "kilo", "lima", "mike", "oscar"
            };


            route[14] = new string[5]
            {
               "juliet", "november", "oscar", "quebec", "romeo"
            };


            string output = " <=> ";

            for (int i = 0; i < jeeplist.Length; i++)
            {
                if (jeeplist[i] == str)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        
                            output += route[i][j] + " <=> ";
                       
                    }
                    resultText.Text = output.ToString();
                    break;
                }
                else
                {
                    resultText.Text = "No route. Please make sure it is correct and capitalized";
                    break;
                }
            }

            




        }
    }
}
