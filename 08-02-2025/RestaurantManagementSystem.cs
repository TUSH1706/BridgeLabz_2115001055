using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    interface Worker
    {
        void PerformDuties();
    }

    class Person
    {
        public string name;
        public int id;

        public Person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("General Person");
        }
    }


    class Chef : Person, Worker
    {
        public string speciality;

        public Chef(string name, int id, string speciality)
            : base(name, id)
        {
            this.speciality = speciality;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Chef - Speciality: {speciality}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{name} is preparing dishes in the kitchen.");
        }
    }

    class Waiter : Person, Worker
    {
        public int tablesAssigned;

        public Waiter(string name, int id, int tablesAssigned)
            : base(name, id)
        {
            this.tablesAssigned = tablesAssigned;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Waiter - Tables Assigned: {tablesAssigned}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{name} is serving customers at {tablesAssigned} tables.");
        }
    }
 

}
