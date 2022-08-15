using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ypanto_MultiPage.ViewModels;

namespace Ypanto_MultiPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EducationBgView : ContentPage
    {
        Person p1;
        public EducationBgView()
        {
            InitializeComponent();
        }
        public EducationBgView(Person p)
        {
            this.p1 = p;
            InitializeComponent();
            ((EducationBgViewModel)BindingContext).Person = p;
        }
    }
}