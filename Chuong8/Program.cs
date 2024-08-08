using System;

namespace Chuong8
{
    public  class Program
    {
        static void Main(string[] args)
        {
            // khoi tao doi tuong
            Customer customer = new Customer(1, "Hung");
            // su dung property de lay gia tri cac field cua doi tuong 
            Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}");
            Console.ReadKey();    

            //demo person
            Person person = new Person();
            Console.WriteLine($"Person detail: {person.ToString()}");
            person.Name = "Duc Hung";
            person.Age = 28;

            Console.WriteLine($"Person detail: {person.ToString()}");

            //demo indexer
            IndexerClass indexerClass = new IndexerClass();
            //goi indexer de khoi tao ca cs phan tu thu 3 ,5
            indexerClass[3] = 256;
            indexerClass[5] = 1024;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Element:# {i}={indexerClass[i]}");
            }

            //demo2 indexer
            DayCollection dayCollection = new DayCollection();
            Console.WriteLine(dayCollection["Wednesday"]);
            Console.WriteLine(dayCollection["Heart"]);


            //bt1
            EmployeeDetails objDetails = new EmployeeDetails();
            objDetails.EmpName = "Bill";
            objDetails.SetId(10);
            Console.WriteLine("Employee Name:" + objDetails.EmpName);
            Console.WriteLine("Employee Id:" + objDetails.EmpId);

            //bt2
            Balance objBal = new Balance();
            objBal.BalanceAmount = 1005.50;
            Console.WriteLine(objBal.BalanceAmount);

        }
    }
}
