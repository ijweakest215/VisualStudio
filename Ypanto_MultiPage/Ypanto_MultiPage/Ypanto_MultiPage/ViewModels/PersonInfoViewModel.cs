using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Ypanto_MultiPage.Views;

namespace Ypanto_MultiPage.ViewModels
{
    public class PersonInfoViewModel : PersonBaseViewModel
    {
        Person p1;
        
        string firstname, middlename, lastname, birthday, gender;
        public PersonInfoViewModel()
        {
            toEdBg = new Command(async() =>
            {
                p1 = new Person();
                p1.Firstname = firstname;
                p1.Middlename = middlename;
                p1.Lastname = lastname;
                p1.Birthday = birthday;
                p1.Gender = gender;
                await Application.Current.MainPage.Navigation.PushModalAsync(new EducationBgView(p1));
            });
        }

        private Command toEdBg;

        public Command ToEdBg
        {
            get { return toEdBg; }
            set { }
        }
        public Person Person
        {
            get => p1;
            set { SetProperty(ref p1, value); }
        }
        public string Firstname
        {
            get => firstname;
            set { SetProperty(ref firstname, value); }
        }
        public string Middlename
        {
            get => middlename;
            set { SetProperty(ref middlename, value); }
        }
        public string Lastname
        {
            get => lastname;
            set { SetProperty(ref lastname, value); }
        }
        public string Birthday
        {
            get => birthday;
            set { SetProperty(ref birthday, value); }
        }
        public string Gender
        {
            get => gender;
            set { SetProperty(ref gender, value); }
        }

    }
}