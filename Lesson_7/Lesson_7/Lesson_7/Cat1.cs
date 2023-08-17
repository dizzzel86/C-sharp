using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    struct Cat1
    {
        public Cat1(string Breed, string Name)
        {
            this.Breed = Breed;
            this.Name = Name;

        }

        public string Breed;
        public string Name;
    }

    struct Account1
    {
        public string Login;

        public string Password;

        public Account1(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }



    }
    struct Account2
    {
        public string Login;

        private string Password;

        public void SetPassword(string NewPassword)
        {
            this.Password = NewPassword;
        }

        public Account2(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }

    struct Cat3
    {
        private string Breed;
        private string Name;
        public Cat3(string Breed, string Name)
        {
            this.Breed = Breed;
            this.Name = Name;
        }

        private void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetBreed(string Breed)
        {
            this.Breed = Breed;
        }

        public string GetBreed()
        {
            return this.Breed;
        }

    }

    //struct Cat4
    //{

    //    public string EyeColor { get; set; }
    //    public string name;
        

    //    public string Name
    //    {
    //        get { return this.name; }
    //        set { this.name = value; }
    //    }

    //    private string breed;

    //    public string Breed
    //    {
    //        get { return this.breed; }
    //        set { this.breed = value; }
    //    }

    //    public Cat4 (string Breed, string Name)
    //    {
    //        this.breed = Breed;
    //        this.name = Name;
    //    }
    //}


}
