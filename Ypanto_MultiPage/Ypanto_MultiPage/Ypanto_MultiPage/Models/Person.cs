using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ypanto_MultiPage
{
    public class Person
    {
        public Person() 
        {
            Skill1 = " ";
            Skill2 = " ";
            Skill3 = " ";
            Skill4 = " ";
            Skill5 = " ";
        }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Elementary { get; set; }
        public string ElemYear { get; set; }
        public string Highschool { get; set; }
        public string HighYear { get; set; }
        public string College { get; set; }
        public string CollegeYear { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public string Skill5 { get; set; }
    }
}