using System;

namespace Interfaces
{
    class Program
    {
        //interface can not renew
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();


            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());

            //the intern class added after when project is done but nothing changed, just created a new class cause implemented by interface
            projectManager.Add(new InternManager())
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    //inherits - class ------------------------ implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // customer addition codes
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // employee addition codes
            Console.WriteLine("Employee added");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern added");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
