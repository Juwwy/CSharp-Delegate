using System;
namespace CreditBereauTask
{
    
    public class Customer
    {
        public string FullName { get; set; }
        private decimal principal;
        private decimal rate;
        private int time;
        
        

        public Customer(string fullName, decimal principal, decimal rate, int time)
        {
            FullName = fullName;
            this.Principal = principal;
            this.Rate = rate;
            this.Time = time;
        }

        public decimal Principal
        {
            get{ return principal;}
            set{
                if(value > 0)
                {
                    principal = value;
                }
            }
        }

        public decimal Rate
        {
            get{ return rate;}
            set{
                if(value > 0)
                {
                    rate = value;
                }
            }
        }

        public int Time
        {
            get{ return time;}
            set{
                if(value > 0)
                {
                    time = value;
                }
            }
        }

        

        public override string ToString()
        {
            return $"{FullName}\n";
        }
    }
}