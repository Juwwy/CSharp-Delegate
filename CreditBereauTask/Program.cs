using System;
using System.Collections.Generic;

namespace CreditBereauTask
{
    public delegate decimal Interest(decimal p, decimal r, int t);
    
    class Program
    {
        static void Main(string[] args)
        {
        
           Customer customer1 = new Customer("James fred", 86000m, 0.7m, 4);
           Customer customer2 = new Customer("Ayomide Ayinde", 43000m, 0.8m, 2);
           Customer customer3 = new Customer("Michael Davies", 14000m, 0.5m, 7);
           Customer customer4 = new Customer("Edwin Adikwu", 3000m, 0.9m, 4);
           Customer customer5 = new Customer("Hassan Jubril", 83400m, 0.2m, 3);
           Customer customer6 = new Customer("Adeboye Aishat", 9000m, 0.7m, 4);
           Customer customer7 = new Customer("Donald Wallace", 3200m, 0.2m, 10);
           Customer customer8 = new Customer("Ferguson Samuel", 10000m, 0.3m, 4);
           Customer customer9 = new Customer("Omobolanle Judith", 56000m, 0.5m, 2);
           Customer customer10 = new Customer("Olatoye Samson", 3400m, 0.35m, 1);

           ICollection<Customer> customers = new List<Customer>(){
               new Customer("James fred", 86000m, 0.7m, 4),
               new Customer("Ayomide Ayinde", 43000m, 0.8m, 2),
               new Customer("Michael Davies", 14000m, 0.5m, 7),
               new Customer("Edwin Adikwu", 3000m, 0.9m, 4),
               new Customer("Hassan Jubril", 83400m, 0.2m, 3),
               new Customer("Adeboye Aishat", 9000m, 0.7m, 4),
               new Customer("Donald Wallace", 3200m, 0.2m, 10),
               new Customer("Ferguson Samuel", 10000m, 0.3m, 4),
               new Customer("Omobolanle Judith", 56000m, 0.5m, 2),
               new Customer("Olatoye Samson", 3400m, 0.35m, 1)

               };

               Interest calculate = SimpleInterest;
               Interest calculate2 = CompoundInterest;
               Console.WriteLine($"{customer1}Loan Simple Interest: {calculate(8600m, 0.7m, 4)}\nCompound Interest: {calculate2(8600m, 0.7m, 4)} \n");
               Console.WriteLine($"{customer2}Loan Simple Interest: {calculate(43000m, 0.8m, 2)}\nCompound Interest: {calculate2(43000m, 0.8m, 2)} \n");
               Console.WriteLine($"{customer3}Loan Simple Interest: {calculate(14000m, 0.5m, 7)}\nCompound Interest: {calculate2(14000m, 0.5m, 7)} \n");
               Console.WriteLine($"{customer4}Loan Simple Interest: {calculate(3000m, 0.9m, 4)}\nCompound Interest: {calculate2(3000m, 0.9m, 4)} \n");
               
        }
        public static decimal SimpleInterest(decimal p, decimal r, int t)
        {
            return (p * r * t)/100;
        }

        public static decimal CompoundInterest(decimal p, decimal r, int t)
        {
            decimal interest = 1;
            decimal cInterest = 0;
          for (int i = 0; i < t; i++)
          {
              interest *= 1 + r;
          }
          cInterest = p * interest;
          return  cInterest;
        }

        
    }
}
