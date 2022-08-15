using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ypanto_MultiPage.ViewModels
{
    public class SummaryViewModel : PersonBaseViewModel
    {
        public Person p1;
        public SummaryViewModel()
        {
   
        }
        public Person Person
        {
            get => p1;
            set { SetProperty(ref p1, value); }
        }
        
    }
}                             
    