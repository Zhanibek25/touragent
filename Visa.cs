using System;

namespace Tour
{
    class Visa
    {
        private int idVisa = 1;
        private int clientID = 1;
        private string typeVisa;
        private string dateStartVisa;
        private string dateFinishVisa;
        
        public Visa()
        {
            this.idVisa++;
            this.typeVisa = "defaultTypeVisa";
            this.dateStartVisa = "defaultStartVisa";
            this.dateFinishVisa = "defaultFinishVisa";
            this.clientID++;
        }
        public Visa(string typeVisa, string dateStaVis, string dateFiVisa)
        {
            this.idVisa++;
            this.typeVisa = typeVisa;
            this.dateStartVisa = dateStartVisa;
            this.dateFinishVisa = dateFinishVisa;
            this.clientID++;
        }
        public string TypeVisa 
        {
            set
            {
                typeVisa = value;
            }
            get
            {
                return typeVisa;
            }
        }
        public string DateStartVisa
        {
            set
            {
                if(value.Length == 9)
                {
                    dateStartVisa = value;
                }
                else
                {
                    Console.WriteLine("Berilgen kunin durys engiziniz:");
                }   
            }
            get
            {
                return dateStartVisa;    
            }
        }
        public string DateFinishVisa
        {
            set
            {
                if(value.Length == 9)
                {
                    dateFinishVisa = value;
                }
                else
                {
                    Console.WriteLine("Bitken kunin durys engiziniz:");
                }   
            }
            get
            {
                return dateFinishVisa;    
            }
        }
    }
}