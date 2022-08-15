using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Ypanto_MultiPage.Views;

namespace Ypanto_MultiPage.ViewModels
{
    public class EducationBgViewModel : PersonBaseViewModel
    {
        Person p1;
        string elem, elemyear, high, highyear, college;
        public EducationBgViewModel()
        {
            toSkills = new Command(async () =>
            {
                p1.Elementary = elem;
                p1.ElemYear = elemyear;
                p1.Highschool = high;
                p1.HighYear = highyear;
                p1.College = college;
                p1.CollegeYear = "Present";
                await Application.Current.MainPage.Navigation.PushModalAsync(new SkillsView(p1));
            });
            exitMe = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
        Command toSkills, exitMe;

        public Command ToSkills
        {
            get { return toSkills; }
            set { }
        }
        public Command ExitMe
        {
            get { return exitMe; }
            set { }
        }

        public Person Person
        {
            get => p1;
            set { SetProperty(ref p1, value); }
        }
        public string Elementary
        {
            get { return elem; }
            set { SetProperty(ref elem, value); }
        }
        public string ElemYear
        {
            get { return elemyear; }
            set { SetProperty(ref elemyear, value); }
        }
        public string Highschool
        {
            get { return high; }
            set { SetProperty(ref high, value); }
        }
        public string HighYear
        {
            get { return highyear; }
            set { SetProperty(ref highyear, value); }
        }
        public string College
        {
            get { return college; }
            set { SetProperty(ref college, value); }
        }
    }
}