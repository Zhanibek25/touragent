using System;

namespace Tour
{
    class Client
    {
        private string name;
        private string lastName;
        private string phone;
        private string passport;
        private int clientID = 1;

        public Client()
        {
            this.name = "defaultName";
            this.lastName = "defaultLastName";
            this.phone = "defaultPhoneNmb";
            this.passport = "defaultPassportNmb";
            this.clientID++;
        }

        public Client(string name, string lastName, string phone,
            string passport)
        {
            this.name = name;
            this.lastName = lastName;
            this.phone = phone;
            this.passport = passport;
            this.clientID++;
        }
        

        public string Name
        {
            set
            {
                name = value.ToUpper();
            }
            get
            {
                return name;
            }
        }

        public string LastName
        {
            set
            {
                lastName = value.ToUpper();//ZHANIBEK
            }
            get
            {
                return lastName;
            }
        }

        public string Phone
        {
            set
            {
                if(value.Length == 12)//+7 707 123 45 68 //+77071234568
                {
                    phone = value;
                } else
                {
                    Console.WriteLine("Nomerdi duris engiziniz");
                }
            }
            get
            {
                return phone;
            }
        }

        public string Passport
        {
            set
            {
                if(value.Length == 9)
                {
                    passport = value;
                }
                else
                {
                    Console.WriteLine("Passport nomerin duris engiziniz");
                }
            }
            get
            {
                return passport;
            }
        }


    }
}