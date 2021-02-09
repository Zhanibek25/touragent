using System;

namespace Tour
{
    class ZagranPassport
    {
        private int passportID = 1;
        private string clientName; 
        private int clientID = 1;
        private string passportNumber;
        private string dateStartPassport;
        private string dateFinishPassport;

        public ZagranPassport()
        {
            this.passportID++;
            this.clientName = "defaultName";
            this.clientID++;
            this.passportNumber = "defaultPassportNumber";
            this.dateStartPassport = "defaultDateStartPassport";
            this.dateFinishPassport = "defaultDateFinishPassport";
        }

        public ZagranPassport(string clientName, string passportNumber, string dateStartPassport, string dateFinishPassport)
        {
            this.passportID++;
            this.clientName = clientName;
            this.clientID++;
            this.passportNumber = passportNumber;
            this.dateStartPassport = dateStartPassport;
            this.dateFinishPassport = dateFinishPassport;
        }

        public string ClientName
        {
            set
            {
                clientName = value.ToUpper();
            }
            get
            {
                return clientName;
            }
        }

        public string PassportNumber
        {
            set
            {
                if(value.Length == 9)
                {
                    passportNumber = value;
                }
                else
                {
                    Console.WriteLine("Passport nomerin duris engiziniz");
                }
            }
            get
            {
                return passportNumber;
            }
        }

        public string DateStartPassport
        {
            set
            {
                dateStartPassport = value;
            }
            get
            {
                return dateStartPassport;
            }
        }
        
        public string DateFinishPassport
        {
            set
            {
                dateFinishPassport = value;
            }
            get
            {
                return dateFinishPassport;
            }
        }
    }
}