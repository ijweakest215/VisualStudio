using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ypanto_MultiPage.ViewModels
{
    public class SkillsViewModel : PersonBaseViewModel
    {
        Person p1;
        string skill1 = " ";
        string skill2 = " ";
        string skill3 = " ";
        string skill4 = " ";
        string skill5 = " ";
        public SkillsViewModel()
        {
            toSummary = new Command(async () =>
            {
                
                p1.Skill1 = skill1;
                p1.Skill2 = skill2;
                p1.Skill3 = skill3;
                p1.Skill4 = skill4;
                p1.Skill5 = skill5;
                /*Console.WriteLine(p1.Firstname);
                Console.WriteLine(p1.Middlename);
                Console.WriteLine(p1.Lastname);
                Console.WriteLine(p1.Birthday);
                Console.WriteLine(p1.Gender);
                Console.WriteLine(p1.Elementary);
                Console.WriteLine(p1.ElemYear);
                Console.WriteLine(p1.Highschool);
                Console.WriteLine(p1.HighYear);
                Console.WriteLine(p1.College);
                Console.WriteLine(p1.CollegeYear);
                Console.WriteLine(p1.Skill1);
                Console.WriteLine(p1.Skill2);
                Console.WriteLine(p1.Skill3);
                Console.WriteLine(p1.Skill4);
                Console.WriteLine(p1.Skill5);*/
                await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(p1));
            });
            exitMe = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }
        Command toSummary, exitMe;

        public Command ToSummary
        {
            get { return toSummary; }
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
        public string Skill1
        {
            get { return skill1; }
            set { SetProperty(ref skill1, value); }
        }
        public string Skill2
        {
            get { return skill2; }
            set { SetProperty(ref skill2, value); }
        }
        public string Skill3
        {
            get { return skill3; }
            set { SetProperty(ref skill3, value); }
        }
        public string Skill4
        {
            get { return skill4; }
            set { SetProperty(ref skill4, value); }
        }
        public string Skill5
        {
            get { return skill5; }
            set { SetProperty(ref skill5, value); }
        }
    }
}