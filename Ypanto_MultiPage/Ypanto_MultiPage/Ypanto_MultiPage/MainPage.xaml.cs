using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ypanto_MultiPage.ViewModels;

namespace Ypanto_MultiPage
{
    public partial class MainPage : ContentPage
    {
        Person p1;
        string fullname, birthday, gender, js, high, coll, skills1, skills2, skills3, skills4, skills5;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(Person p)
        {
            this.p1 = p;
            
            InitializeComponent();
            SetLabels(p1);

        }
        public void SetLabels(Person p1)
        {
            fullname = " " + p1.Firstname + " " + p1.Middlename + " " + p1.Lastname;
            birthday = p1.Birthday;
            gender = p1.Gender;
            js = p1.Elementary + ", " + p1.ElemYear;
            high = p1.Highschool + ", " + p1.HighYear;
            coll = p1.College + ", " + p1.CollegeYear;
            skills1 = p1.Skill1;
            skills2 = p1.Skill2;
            skills3 = p1.Skill3;
            skills4 = p1.Skill4;
            skills5 = p1.Skill5;

            name.Text = fullname.ToString();
            bday.Text = birthday.ToString();
            sex.Text = gender.ToString();
            elem.Text = js.ToString();
            hs.Text = high.ToString();
            college.Text = coll.ToString();
            skill1.Text = skills1.ToString();
            skill2.Text = skills2.ToString();
            skill3.Text = skills3.ToString();
            skill4.Text = skills4.ToString();
            skill5.Text = skills5.ToString();

        }
    }
}

